using System.Numerics;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WPFBoids.Views;

namespace WPFBoids.Models
{
    public class Boid : Image
    {
        // Constant flocking values
        private int perceptionRadius = 30;
        private int maxSpeed = 3;
        private int minSpeed = 1;
        private int maxForce = 1;

        // Movement vectors
        public Vector2 position = new Vector2(); // Public for canvas to read it
        private Vector2 velocity = new Vector2();
        private Vector2 acceleration = new Vector2();

        private Random random = new Random();

        public Boid()
        {
            // Display properties
            this.Source = new BitmapImage(new Uri("Models/Boid.png", UriKind.Relative));
            this.Width = 4;
            this.Height = 4;

            // Initializing flocking logic properties
            this.position.X = random.Next(0, 300);
            this.position.Y = random.Next(0, 300);

            this.velocity.X = random.Next(-5, 5);
            this.velocity.Y = random.Next(-5, 5);

            this.acceleration = Vector2.Zero;
        }

        public void Edges()
        {
            int canvas_size = 320;

            if (this.position.X > canvas_size - 4) { this.position.X = 4; }
            else if (this.position.X < 4) { this.position.X = canvas_size - 4; }

            if (this.position.Y > canvas_size - 4) { this.position.Y = 4; }
            else if (this.position.Y < 4) { this.position.Y = canvas_size - 4; }
        }

        private Vector2 Align(List<Boid> flock)
        {
            Vector2 steering = Vector2.Zero;
            int total = 0;

            foreach (Boid boid in flock)
            {
                if (boid == this) continue;

                double dist = Vector2.Distance(this.position, boid.position);
                if (dist < perceptionRadius)
                {
                    steering += boid.velocity;
                    total++;
                }
            }

            if (total > 0)
            {
                steering = steering / total;

                // No built in function for setting magnitude, normalize and multiply instead
                steering = Vector2.Normalize(steering);
                steering = Vector2.Multiply(steering, this.maxSpeed);

                steering -= this.velocity;

                steering = Limit(steering, maxForce);

            }
            return steering;
        }

        private Vector2 Cohesion(List<Boid> flock)
        {
            Vector2 steering = Vector2.Zero;
            int total = 0;


            foreach (Boid boid in flock)
            {
                if (boid == this) continue;

                double dist = Vector2.Distance(this.position, boid.position);

                if (dist <= this.perceptionRadius * 2)
                {
                    steering += boid.position;
                    total++;
                }
            }

            if (total > 0)
            {
                steering /= total;
                steering -= this.position;

                // Set magnitude
                steering = Vector2.Normalize(steering);
                steering = Vector2.Multiply(steering, this.maxSpeed);

                steering -= this.velocity;
                steering = Limit(steering, maxForce);
            }

            return steering;
        }

        private Vector2 Separation(List<Boid> flock)
        {
            Vector2 steering = Vector2.Zero;
            int total = 0;

            foreach (Boid boid in flock)
            {
                if (boid == this) continue;

                float dist = Vector2.Distance(this.position, boid.position);
                if (dist <= this.perceptionRadius * 2)
                {
                    Vector2 diff = this.position - boid.position;
                    diff = Vector2.Divide(diff, dist * dist);
                    steering += diff;
                    total++;
                }
            }

            if (total > 0)
            {
                steering /= total;

                // Set magnitude
                steering = Vector2.Normalize(steering);
                steering = Vector2.Multiply(steering, this.maxSpeed);
                steering -= this.velocity;
                steering = Limit(steering, maxForce);
            }
            return steering;
        }

        public void Flock(List<Boid> flock)
        {
            Vector2 alignment = this.Align(flock);
            Vector2 cohesion = this.Cohesion(flock);
            Vector2 separation = this.Separation(flock);

            // Singleton control panel multipliers
            alignment = alignment * (float)(ControlPanel.Instance?.alignment_mult ?? 1);
            cohesion = cohesion * (float)(ControlPanel.Instance?.cohesion_mult ?? 1);
            separation = separation * (float)(ControlPanel.Instance?.separation_mult ?? 1);

            this.acceleration += alignment;
            this.acceleration += cohesion;
            this.acceleration += separation;
        }

        private int test = 0;
        public void Update()
        {
            this.position += this.velocity;
            this.velocity += this.acceleration;
            this.velocity = Limit(this.velocity, this.maxSpeed);

            // Lock prevention
            this.acceleration = Vector2.Zero;
        }


        // C# Vector2 has no built in limit function, this will cap the Vector's X and Y to a certain positive or negative value
        static Vector2 Limit(Vector2 vec, int U_int)
        {
            if (vec.X > 0)
            {
                vec.X = Math.Min(U_int, vec.X);
            }
            else if (vec.X < 0)
            {
                vec.X = Math.Max(-U_int, vec.X);
            }

            if (vec.Y > 0)
            {
                vec.Y = Math.Min(U_int, vec.Y);
            }
            else if (vec.Y < 0)
            {
                vec.Y = Math.Max(-U_int, vec.Y);
            }

            return vec;
        }
    }
}
