using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace ProjectTemplate.Views.Behaviors
{
    public class BlinkBehavior : Behavior<UIElement>
    {

        protected override void OnAttached()
        {
            AssociatedObject.BlinkEasing();
        }

    }
}
