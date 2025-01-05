using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBoids.Views
{
    /// <summary>
    /// Interaction logic for ControlPanel.xaml
    /// </summary>
    public partial class ControlPanel : Grid
    {

        // Initial multiplier values
        public double alignment_mult = 1;
        public double cohesion_mult = 1;
        public double separation_mult = 1;

        // Singleton instance for boids to reference
        public static ControlPanel? Instance { get; set; }

        public ControlPanel()
        {
            InitializeComponent();
            Instance = this;
        }
    
        public void Alignment_Changed(object sender, EventArgs e)
        {
            this.alignment_mult = AlignmentSlider.Value;
        }

        public void Cohesion_Change(object sender, EventArgs e)
        {
            this.cohesion_mult = CohesionSlider.Value;
        }

        public void Separation_Changed(object sender, EventArgs e) {
            this.separation_mult = SeparationSlider.Value;        
        }
    }
}
