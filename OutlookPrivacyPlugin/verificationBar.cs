using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;
using Color = System.Drawing.Color;

namespace OutlookPrivacyPlugin
{
    partial class verificationBar
    {
        #region Formularbereichsfactory

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
        [Microsoft.Office.Tools.Outlook.FormRegionName("OutlookPrivacyPlugin.FormRegion1")]
        public partial class FormRegion1Factory
        {
            // Tritt ein, bevor der Formularbereich initialisiert wird.
            // Um die Anzeige des Formularbereichs zu verhindern, legen Sie e.Cancel auf True fest.
            // Verwenden Sie e.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
            private void FormRegion1Factory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }
        
        #endregion

        // Tritt ein, bevor der Formularbereich angezeigt wird.
        // Verwenden Sie this.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
        // Verwenden Sie this.OutlookFormRegion, um einen Verweis auf den Formularbereich abzurufen.
        private void FormRegion1_FormRegionShowing(object sender, System.EventArgs e)
        {
        }

        // Tritt ein, wenn der Formularbereich geschlossen wird.
        // Verwenden Sie this.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
        // Verwenden Sie this.OutlookFormRegion, um einen Verweis auf den Formularbereich abzurufen.
        private void FormRegion1_FormRegionClosed(object sender, System.EventArgs e)
        {
        }

        private void status_Click_1(object sender, EventArgs e)
        {
            this.status.BackColor = Color.Crimson;
            this.status.Text = "verified";
        }

        public void status_valid()
        {
            status.Text = "Valid Signature!";
            status.BackColor = Color.PaleGreen;
        }

        public void status_invalid()
        {
            this.Enabled = true;
            status.Text = "Invalid Signature!";
            status.BackColor = Color.Red;
        }
    }
}
