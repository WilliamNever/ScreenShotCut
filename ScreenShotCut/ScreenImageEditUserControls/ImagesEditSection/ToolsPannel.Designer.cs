namespace ScreenImageEditUserControls.ImagesEditSection
{
    partial class ToolsPannel
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
            this.tabTools = new System.Windows.Forms.TabControl();
            this.tpSelect = new System.Windows.Forms.TabPage();
            this.tpText = new System.Windows.Forms.TabPage();
            this.btnAddToShow = new System.Windows.Forms.Button();
            this.cbkBold = new System.Windows.Forms.CheckBox();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.cbkUnderLine = new System.Windows.Forms.CheckBox();
            this.cbkStrkeOut = new System.Windows.Forms.CheckBox();
            this.cbkItalic = new System.Windows.Forms.CheckBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblShowSample = new System.Windows.Forms.Label();
            this.cbbFontList = new System.Windows.Forms.ComboBox();
            this.tpRectangle = new System.Windows.Forms.TabPage();
            this.tpScale = new System.Windows.Forms.TabPage();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.clDlgPickColor = new System.Windows.Forms.ColorDialog();
            this.cbkBgColor = new System.Windows.Forms.CheckBox();
            this.btnBgColor = new System.Windows.Forms.Button();
            this.tabTools.SuspendLayout();
            this.tpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTools
            // 
            this.tabTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTools.Controls.Add(this.tpSelect);
            this.tabTools.Controls.Add(this.tpText);
            this.tabTools.Controls.Add(this.tpRectangle);
            this.tabTools.Controls.Add(this.tpScale);
            this.tabTools.Location = new System.Drawing.Point(0, 20);
            this.tabTools.Name = "tabTools";
            this.tabTools.SelectedIndex = 0;
            this.tabTools.Size = new System.Drawing.Size(256, 345);
            this.tabTools.TabIndex = 0;
            // 
            // tpSelect
            // 
            this.tpSelect.AutoScroll = true;
            this.tpSelect.Location = new System.Drawing.Point(4, 22);
            this.tpSelect.Name = "tpSelect";
            this.tpSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelect.Size = new System.Drawing.Size(248, 259);
            this.tpSelect.TabIndex = 0;
            this.tpSelect.Text = "Select";
            this.tpSelect.UseVisualStyleBackColor = true;
            // 
            // tpText
            // 
            this.tpText.AutoScroll = true;
            this.tpText.Controls.Add(this.btnBgColor);
            this.tpText.Controls.Add(this.cbkBgColor);
            this.tpText.Controls.Add(this.btnAddToShow);
            this.tpText.Controls.Add(this.cbkBold);
            this.tpText.Controls.Add(this.btnPickColor);
            this.tpText.Controls.Add(this.cbkUnderLine);
            this.tpText.Controls.Add(this.cbkStrkeOut);
            this.tpText.Controls.Add(this.cbkItalic);
            this.tpText.Controls.Add(this.lblFontSize);
            this.tpText.Controls.Add(this.txtFontSize);
            this.tpText.Controls.Add(this.btnDemo);
            this.tpText.Controls.Add(this.txtInput);
            this.tpText.Controls.Add(this.lblShowSample);
            this.tpText.Controls.Add(this.cbbFontList);
            this.tpText.Location = new System.Drawing.Point(4, 22);
            this.tpText.Name = "tpText";
            this.tpText.Padding = new System.Windows.Forms.Padding(3);
            this.tpText.Size = new System.Drawing.Size(248, 319);
            this.tpText.TabIndex = 1;
            this.tpText.Text = "Text";
            this.tpText.UseVisualStyleBackColor = true;
            // 
            // btnAddToShow
            // 
            this.btnAddToShow.Location = new System.Drawing.Point(167, 290);
            this.btnAddToShow.Name = "btnAddToShow";
            this.btnAddToShow.Size = new System.Drawing.Size(75, 23);
            this.btnAddToShow.TabIndex = 11;
            this.btnAddToShow.Text = "Add";
            this.btnAddToShow.UseVisualStyleBackColor = true;
            this.btnAddToShow.Click += new System.EventHandler(this.btnAddToShow_Click);
            // 
            // cbkBold
            // 
            this.cbkBold.AutoSize = true;
            this.cbkBold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbkBold.Location = new System.Drawing.Point(6, 207);
            this.cbkBold.Name = "cbkBold";
            this.cbkBold.Size = new System.Drawing.Size(50, 17);
            this.cbkBold.TabIndex = 10;
            this.cbkBold.Text = "Bold:";
            this.cbkBold.UseVisualStyleBackColor = true;
            // 
            // btnPickColor
            // 
            this.btnPickColor.BackColor = System.Drawing.Color.Black;
            this.btnPickColor.FlatAppearance.BorderSize = 0;
            this.btnPickColor.Location = new System.Drawing.Point(165, 178);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(77, 23);
            this.btnPickColor.TabIndex = 9;
            this.btnPickColor.Text = "Pick Color";
            this.btnPickColor.UseVisualStyleBackColor = false;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // cbkUnderLine
            // 
            this.cbkUnderLine.AutoSize = true;
            this.cbkUnderLine.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbkUnderLine.Location = new System.Drawing.Point(127, 207);
            this.cbkUnderLine.Name = "cbkUnderLine";
            this.cbkUnderLine.Size = new System.Drawing.Size(43, 17);
            this.cbkUnderLine.TabIndex = 8;
            this.cbkUnderLine.Text = "UL:";
            this.cbkUnderLine.UseVisualStyleBackColor = true;
            // 
            // cbkStrkeOut
            // 
            this.cbkStrkeOut.AutoSize = true;
            this.cbkStrkeOut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbkStrkeOut.Location = new System.Drawing.Point(180, 207);
            this.cbkStrkeOut.Name = "cbkStrkeOut";
            this.cbkStrkeOut.Size = new System.Drawing.Size(60, 17);
            this.cbkStrkeOut.TabIndex = 7;
            this.cbkStrkeOut.Text = "Strake:";
            this.cbkStrkeOut.UseVisualStyleBackColor = true;
            // 
            // cbkItalic
            // 
            this.cbkItalic.AutoSize = true;
            this.cbkItalic.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbkItalic.Location = new System.Drawing.Point(66, 207);
            this.cbkItalic.Name = "cbkItalic";
            this.cbkItalic.Size = new System.Drawing.Size(51, 17);
            this.cbkItalic.TabIndex = 6;
            this.cbkItalic.Text = "Italic:";
            this.cbkItalic.UseVisualStyleBackColor = true;
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFontSize.Location = new System.Drawing.Point(6, 183);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(54, 13);
            this.lblFontSize.TabIndex = 5;
            this.lblFontSize.Text = "Font Size:";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(66, 179);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(93, 20);
            this.txtFontSize.TabIndex = 4;
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(6, 290);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(74, 23);
            this.btnDemo.TabIndex = 3;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(6, 75);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(236, 67);
            this.txtInput.TabIndex = 2;
            // 
            // lblShowSample
            // 
            this.lblShowSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowSample.AutoEllipsis = true;
            this.lblShowSample.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSample.Location = new System.Drawing.Point(6, 14);
            this.lblShowSample.Name = "lblShowSample";
            this.lblShowSample.Size = new System.Drawing.Size(236, 54);
            this.lblShowSample.TabIndex = 1;
            this.lblShowSample.Text = "AaEeGgIiLlOoQqZz";
            // 
            // cbbFontList
            // 
            this.cbbFontList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFontList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFontList.FormattingEnabled = true;
            this.cbbFontList.Location = new System.Drawing.Point(6, 150);
            this.cbbFontList.Name = "cbbFontList";
            this.cbbFontList.Size = new System.Drawing.Size(236, 21);
            this.cbbFontList.TabIndex = 0;
            this.cbbFontList.SelectedIndexChanged += new System.EventHandler(this.cbbFontList_SelectedIndexChanged);
            // 
            // tpRectangle
            // 
            this.tpRectangle.AutoScroll = true;
            this.tpRectangle.Location = new System.Drawing.Point(4, 22);
            this.tpRectangle.Name = "tpRectangle";
            this.tpRectangle.Padding = new System.Windows.Forms.Padding(3);
            this.tpRectangle.Size = new System.Drawing.Size(248, 259);
            this.tpRectangle.TabIndex = 2;
            this.tpRectangle.Text = "Rectangle";
            this.tpRectangle.UseVisualStyleBackColor = true;
            // 
            // tpScale
            // 
            this.tpScale.AutoScroll = true;
            this.tpScale.Location = new System.Drawing.Point(4, 22);
            this.tpScale.Name = "tpScale";
            this.tpScale.Padding = new System.Windows.Forms.Padding(3);
            this.tpScale.Size = new System.Drawing.Size(248, 259);
            this.tpScale.TabIndex = 3;
            this.tpScale.Text = "Scale";
            this.tpScale.UseVisualStyleBackColor = true;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.SystemColors.Control;
            this.lblClose.Location = new System.Drawing.Point(239, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(14, 13);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Blue;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(256, 22);
            this.pnlTitle.TabIndex = 2;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // clDlgPickColor
            // 
            this.clDlgPickColor.AnyColor = true;
            // 
            // cbkBgColor
            // 
            this.cbkBgColor.AutoSize = true;
            this.cbkBgColor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbkBgColor.Location = new System.Drawing.Point(6, 230);
            this.cbkBgColor.Name = "cbkBgColor";
            this.cbkBgColor.Size = new System.Drawing.Size(78, 17);
            this.cbkBgColor.TabIndex = 12;
            this.cbkBgColor.Text = "BackColor:";
            this.cbkBgColor.UseVisualStyleBackColor = true;
            // 
            // btnBgColor
            // 
            this.btnBgColor.BackColor = System.Drawing.Color.Black;
            this.btnBgColor.FlatAppearance.BorderSize = 0;
            this.btnBgColor.Location = new System.Drawing.Point(93, 226);
            this.btnBgColor.Name = "btnBgColor";
            this.btnBgColor.Size = new System.Drawing.Size(77, 23);
            this.btnBgColor.TabIndex = 13;
            this.btnBgColor.Text = "Pick Color";
            this.btnBgColor.UseVisualStyleBackColor = false;
            this.btnBgColor.Click += new System.EventHandler(this.btnBgColor_Click);
            // 
            // ToolsPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.tabTools);
            this.Controls.Add(this.pnlTitle);
            this.Name = "ToolsPannel";
            this.Size = new System.Drawing.Size(256, 365);
            this.Load += new System.EventHandler(this.ToolsPannel_Load);
            this.tabTools.ResumeLayout(false);
            this.tpText.ResumeLayout(false);
            this.tpText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTools;
        private System.Windows.Forms.TabPage tpSelect;
        private System.Windows.Forms.TabPage tpText;
        private System.Windows.Forms.TabPage tpRectangle;
        private System.Windows.Forms.TabPage tpScale;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.ComboBox cbbFontList;
        private System.Windows.Forms.Label lblShowSample;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.CheckBox cbkItalic;
        private System.Windows.Forms.CheckBox cbkStrkeOut;
        private System.Windows.Forms.CheckBox cbkUnderLine;
        private System.Windows.Forms.ColorDialog clDlgPickColor;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.CheckBox cbkBold;
        private System.Windows.Forms.Button btnAddToShow;
        private System.Windows.Forms.CheckBox cbkBgColor;
        private System.Windows.Forms.Button btnBgColor;
    }
}
