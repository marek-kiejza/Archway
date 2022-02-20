using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorApprentice;
//using System.Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> ProjectName = new List<string>();
        List<string> ProjectValue = new List<string>();


        ApprenticeServerDocument oAppDoc;
        ApprenticeServerComponent oSvr = new ApprenticeServerComponent();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileFileter = "*.iam;*.idw;*.dwg;*.ipt;*.ipn;*.ide";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.Filter = "Inventer files (" + FileFileter + ")|" + FileFileter + "|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ShowDialog();

            //textBox1.Text = openFileDialog1.FileName;
            //MessageBox.Show("textBox1.Text");


            if (openFileDialog1.FileName == "") return;
            ReadiProperties(openFileDialog1.FileName);
        }
        private void ReadiProperties(string location)
        {
            string pName="", pValue="";

            oAppDoc = oSvr.Open(location);
            if (oAppDoc == null) return;
          //  MessageBox.Show("Got Here");


            foreach (InventorApprentice.PropertySet propSet in oAppDoc.PropertySets)
            {
                lstProperties.Items.Add("PropertySet: " + propSet.Name + ", " + propSet.InternalName);
                foreach (InventorApprentice.Property oprop in propSet)
                {
                    String name = oprop.Name;
                    Object value = oprop.Value;
                    int int_name = oprop.PropId;
                    /*if (value !=null)  {     
                        System.Type varType = value.GetType();   
                        if (varType.FullName == "System.__ComObject") {
                            value = "Bitmap";
                        }
                    }*/

                    lstProperties.Items.Add("         " + name + " , " + value);

                    if (name == "Document Sub Type Name")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Part Number")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Stock Number")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Description")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Revision Number")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Project")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Designer")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Engineer")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Authority")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Cost Center")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Cost")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add("€" + value.ToString());
                    }
                    if (name == "Creation Time")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Vendor")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }
                    if (name == "Catalog Web Link")
                    {
                        ProjectName.Add(name);
                        ProjectValue.Add(value.ToString());
                    }

                    //  label1.Text = name+":\t" + value.ToString()+" \n";

                }

              

            }
                  foreach (var item in ProjectName)
                   {
                      pName += item + " :\n";
                   }
                  foreach (var item in ProjectValue)
                  {
                      pValue += item.ToString() + " \n";
                  }

            label1.Text = pName;
            label2.Text = pValue;

            PropertySet oPropertySet = oAppDoc.PropertySets["{F29F85E0-4FF9-1068-AB91-08002B27B3D9}"];
            InventorApprentice.Property oProperty = oPropertySet["Author"];
            string Test = oProperty.Value;
           // MessageBox.Show("Got Here: " + Test);
            //oAppDoc.PropertySets.FlushToFile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string NewString = "Changed Value";
            PropertySet oPropertySet = oAppDoc.PropertySets["{F29F85E0-4FF9-1068-AB91-08002B27B3D9}"];
            //Get Author property
            InventorApprentice.Property oProperty = oPropertySet["Author"];
            oProperty.Value = NewString;
            oAppDoc.PropertySets.FlushToFile();
            */
        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            Excel.Application appExcel = new Excel.Application();
            appExcel.Visible = false;
            Excel.Workbook workbook = appExcel.Workbooks.Add(1);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            workbook.SaveAs(save_file_name, Excel.XlFileFormat.xlWorkbookDefault);
            appExcel.Workbooks.Close();
            appExcel.Quit();*/
        }
    }
}
