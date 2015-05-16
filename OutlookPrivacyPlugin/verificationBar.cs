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

        #region different_statuses
        public void status_valid(string userid, string keyid)
        {
            status.Text = "Valid Signature! User ID: "+userid+" Key ID: "+keyid;
            status.BackColor = Color.PaleGreen;
        }

        public void status_invalid(string userid, string keyid)
        {
            status.Text = "Invalid Signature! User ID: "+userid+" Key ID: "+keyid;
            status.BackColor = Color.Tomato;
        }

        public void status_partial(string userid, string keyid)
        {
            status.Text = "Message Partially Signed! User ID: "+userid+" Key ID: "+keyid;
            status.BackColor = Color.Yellow;
        }

        public void status_green(string text)
        {
            status.Text = text;
            status.BackColor = Color.PaleGreen;
        }

        public void status_red(string text)
        {
            status.Text = text;
            status.BackColor = Color.Tomato;
        }

        public void status_yellow(string text)
        {
            status.Text = text;
            status.BackColor = Color.Yellow;
        }

        public void status_gray(string text)
        {
            status.Text = text;
            status.BackColor = Color.LightGray;
        }

        public void status_unable(string reason)
        {
            status.Text = "Unable to Verify! (" + reason + ")";
            status.BackColor = Color.Tomato;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
