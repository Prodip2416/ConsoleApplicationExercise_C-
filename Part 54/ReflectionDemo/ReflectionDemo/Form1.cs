using System;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiscoveryTypeInformation_Click(object sender, EventArgs e)
        {
            // System.String input this,,,,,,,
            /*
              Set the Name of the text box to txtTypeName
              Set the Name of the button to btnDiscoverTypeInformation
              Set the Name of the list boxes, to lstMethods, lstProperties, and lstConstructors
              Now double click the button control to generate the event hand
             */


            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);
            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstConstructors.Items.Clear();
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
            }
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor.ToString());
            }
        }
    }
}
