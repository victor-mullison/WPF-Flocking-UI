using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Diagnostics;

namespace WPFBoids.Models
{
    public class FlockCanvas : System.Windows.Controls.Canvas
    {

        private List<Boid> flock = new List<Boid>();

        private Random random = new Random();

        public FlockCanvas() {

            // Baseclass Canvas UI adjustments
            this.Width = 320;
            this.Height = 320;
            
            for(int i = 0; i < 100; i++)
            {
                Boid new_boid = new Boid();
                this.flock.Add(new_boid);
                Children.Add(new_boid);
                SetLeft(new_boid, random.Next(0, 300));
                SetTop(new_boid, random.Next(0,300));
            };

            // Initial call to update_boids, which then recursively calls itself after a non-blocking delay
            update_boids();
        }

        private async void update_boids()
        {
            

            foreach (Boid boid in flock)
            {
                boid.Edges();
                boid.Flock(this.flock);
                boid.Update();
                
                // After calling boid methods, set canvas position
                SetLeft(boid, boid.position.X - 4);
                SetTop(boid, boid.position.Y - 4);
            }

            await Task.Delay(20);
            update_boids();
        }
    }
}
