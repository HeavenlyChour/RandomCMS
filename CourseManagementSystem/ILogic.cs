using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    interface ILogic
    {

        bool Add();

        bool Delete();

        bool Update();

        bool Search();

        void ViewAll(DataGridView dgvForm);

        void Load(ComboBox[] cmb);
    }
}
