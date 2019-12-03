using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyRegister.Forms
{
    public partial class TypeUnitForm : Form
    {
        public TypeUnitForm()
        {
            InitializeComponent();
        }

        private void TypeUnit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.TypeUnit". При необходимости она может быть перемещена или удалена.
            this.typeUnitTableAdapter.Fill(this.propertyRegisterDataSet.TypeUnit);
        }
    }
}
