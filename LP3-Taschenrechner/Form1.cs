using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LP3_Taschenrechner
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = ""; 
        bool isOperationPerfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Click(object sender, EventArgs e)
        {
            if ((Output.Text == "0" || isOperationPerfomed))
                Output.Clear();

            isOperationPerfomed = false;
            Button button = (Button)sender;
            Output.Text = Output.Text + button.Text;
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue=Double.Parse(Output.Text);
            Lable_Output.Text=resultValue + " " + operationPerformed;
            isOperationPerfomed = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultValue = 0;
            operationPerformed = "";
            Output.Text = "0";
            Lable_Output.Text = " ";
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    Output.Text = (resultValue + Double.Parse(Output.Text)).ToString();
                    break;

                case "-":
                    Output.Text = (resultValue - Double.Parse(Output.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void Set_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}



public class MyUserSettings : ApplicationSettingsBase
{
    [UserScopedSetting()]
    [DefaultSettingValue("White")]
    public Color BackgroundColor
    {
        get
        {
            return ((Color)this["BackgroundColor"]);
        }
        set
        {
            this["BackgroundColor"] = value;
        }
    }
}
