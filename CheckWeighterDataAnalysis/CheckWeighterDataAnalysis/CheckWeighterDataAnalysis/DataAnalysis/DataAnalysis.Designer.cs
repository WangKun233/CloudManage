﻿
namespace CheckWeighterDataAnalysis.DataAnalysis
{
    partial class DataAnalysis
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationFrame_dataAnalysis = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage_timeDomainAnalysis = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage_frequencyDomainAnalysis = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.timeDomainAnalysis1 = new CheckWeighterDataAnalysis.DataAnalysis.TimeDomainAnalysis();
            this.frequencyDomainAnalysis1 = new CheckWeighterDataAnalysis.DataAnalysis.FrequencyDomainAnalysis();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame_dataAnalysis)).BeginInit();
            this.navigationFrame_dataAnalysis.SuspendLayout();
            this.navigationPage_timeDomainAnalysis.SuspendLayout();
            this.navigationPage_frequencyDomainAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationFrame_dataAnalysis
            // 
            this.navigationFrame_dataAnalysis.Controls.Add(this.navigationPage_timeDomainAnalysis);
            this.navigationFrame_dataAnalysis.Controls.Add(this.navigationPage_frequencyDomainAnalysis);
            this.navigationFrame_dataAnalysis.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame_dataAnalysis.Name = "navigationFrame_dataAnalysis";
            this.navigationFrame_dataAnalysis.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage_timeDomainAnalysis,
            this.navigationPage_frequencyDomainAnalysis});
            this.navigationFrame_dataAnalysis.SelectedPage = this.navigationPage_frequencyDomainAnalysis;
            this.navigationFrame_dataAnalysis.Size = new System.Drawing.Size(1024, 617);
            this.navigationFrame_dataAnalysis.TabIndex = 0;
            this.navigationFrame_dataAnalysis.Text = "navigationFrame1";
            this.navigationFrame_dataAnalysis.TransitionAnimationProperties.FrameCount = 3000;
            this.navigationFrame_dataAnalysis.TransitionAnimationProperties.FrameInterval = 1000;
            // 
            // navigationPage_timeDomainAnalysis
            // 
            this.navigationPage_timeDomainAnalysis.Caption = "navigationPage_timeDomainAnalysis";
            this.navigationPage_timeDomainAnalysis.Controls.Add(this.timeDomainAnalysis1);
            this.navigationPage_timeDomainAnalysis.Name = "navigationPage_timeDomainAnalysis";
            this.navigationPage_timeDomainAnalysis.Size = new System.Drawing.Size(1024, 617);
            // 
            // navigationPage_frequencyDomainAnalysis
            // 
            this.navigationPage_frequencyDomainAnalysis.Caption = "navigationPage_frequencyDomainAnalysis";
            this.navigationPage_frequencyDomainAnalysis.Controls.Add(this.frequencyDomainAnalysis1);
            this.navigationPage_frequencyDomainAnalysis.Name = "navigationPage_frequencyDomainAnalysis";
            this.navigationPage_frequencyDomainAnalysis.Size = new System.Drawing.Size(1024, 617);
            // 
            // timeDomainAnalysis1
            // 
            this.timeDomainAnalysis1.Location = new System.Drawing.Point(0, 0);
            this.timeDomainAnalysis1.Name = "timeDomainAnalysis1";
            this.timeDomainAnalysis1.Size = new System.Drawing.Size(1024, 617);
            this.timeDomainAnalysis1.TabIndex = 0;
            // 
            // frequencyDomainAnalysis1
            // 
            this.frequencyDomainAnalysis1.Location = new System.Drawing.Point(0, 0);
            this.frequencyDomainAnalysis1.Name = "frequencyDomainAnalysis1";
            this.frequencyDomainAnalysis1.Size = new System.Drawing.Size(1024, 617);
            this.frequencyDomainAnalysis1.TabIndex = 0;
            // 
            // DataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame_dataAnalysis);
            this.Name = "DataAnalysis";
            this.Size = new System.Drawing.Size(1024, 617);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame_dataAnalysis)).EndInit();
            this.navigationFrame_dataAnalysis.ResumeLayout(false);
            this.navigationPage_timeDomainAnalysis.ResumeLayout(false);
            this.navigationPage_frequencyDomainAnalysis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame_dataAnalysis;
        //private DevExpress.XtraBars.Navigation.NavigationPage navigationPage_timeDomainAnalysis;
        //private DevExpress.XtraBars.Navigation.NavigationPage navigationPage_frequencyDomainAnalysis;
        private TimeDomainAnalysis timeDomainAnalysis1;
        private FrequencyDomainAnalysis frequencyDomainAnalysis1;
    }
}
