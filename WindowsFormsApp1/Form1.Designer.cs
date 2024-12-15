using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Controls (UI elements)
        private TextBox txtPin;
        private Button btnValidate;
        private Label lblResult;

        public Form1()
        {
            // Initialize form components
            InitializeComponent();
        }

        // Event handler for the button click
        private void btnValidate_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text;

            // Validate the PIN
            if (IsValidPin(pin))
            {
                lblResult.Text = "PIN is valid.";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "Invalid PIN. Please enter a 4-digit number.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Method to validate the PIN
        private bool IsValidPin(string pin)
        {
            // Check if the PIN is exactly 4 digits long
            if (pin.Length != 4)
            {
                return false;
            }

            // Check if the PIN contains only numeric digits
            foreach (char c in pin)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true; // Valid PIN
        }

        // Method to initialize the UI components (controls)
        private void InitializeComponent()
        {
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(319, 82);
            this.txtPin.Multiline = true;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(200, 22);
            this.txtPin.TabIndex = 0;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(319, 122);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(200, 30);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(809, 282);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtPin);
            this.Name = "Form1";
            this.Text = "PIN Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    // Program class to start the application
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles and start the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Launches the MainForm
        }
    }
}
