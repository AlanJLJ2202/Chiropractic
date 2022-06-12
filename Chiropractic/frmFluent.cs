using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chiropractic
{
    public partial class frmFluent : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmFluent()
        {
            InitializeComponent();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmRibbon))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Pacientes...");
            frmRibbon myForm = new frmRibbon();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ControlBox = false;
            //myForm.FormBorderStyle = FormBorderStyle.None;

            panelMain.Controls.Add(myForm);
            myForm.Show();
            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmRibbon))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Calendario...");

            frmCalendar myForm = new frmCalendar();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ControlBox = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(myForm);
            myForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmFluent_Load(object sender, EventArgs e)
        {

        }
    }
}
