using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMWindowsForm
{
    [global::System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class ViewModelAttribute : Attribute
    {
        public ViewModelAttribute() { }
        public ViewModelAttribute(bool Activated)
        {
            this.Activated = Activated;
        }

        public bool Activated { get; set; }
    }
}
