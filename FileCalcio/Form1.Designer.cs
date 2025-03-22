namespace FileCalcio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_main = new Panel();
            pnl_entries = new Panel();
            btn_aggiungi = new Button();
            txt_golOspite = new TextBox();
            lbl_golOspite = new Label();
            txt_golCasa = new TextBox();
            lbl_golCasa = new Label();
            txt_squadraOspite = new TextBox();
            lbl_squadraOspite = new Label();
            txt_squadraCasa = new TextBox();
            lbl_squadraCasa = new Label();
            lst_elenco = new ListBox();
            pnl_main.SuspendLayout();
            pnl_entries.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_main.Controls.Add(lst_elenco);
            pnl_main.Controls.Add(pnl_entries);
            pnl_main.Location = new Point(12, 12);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(776, 426);
            pnl_main.TabIndex = 0;
            // 
            // pnl_entries
            // 
            pnl_entries.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_entries.Controls.Add(btn_aggiungi);
            pnl_entries.Controls.Add(txt_golOspite);
            pnl_entries.Controls.Add(lbl_golOspite);
            pnl_entries.Controls.Add(txt_golCasa);
            pnl_entries.Controls.Add(lbl_golCasa);
            pnl_entries.Controls.Add(txt_squadraOspite);
            pnl_entries.Controls.Add(lbl_squadraOspite);
            pnl_entries.Controls.Add(txt_squadraCasa);
            pnl_entries.Controls.Add(lbl_squadraCasa);
            pnl_entries.Location = new Point(3, 3);
            pnl_entries.Name = "pnl_entries";
            pnl_entries.Size = new Size(770, 103);
            pnl_entries.TabIndex = 0;
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aggiungi.Location = new Point(697, 21);
            btn_aggiungi.Margin = new Padding(0);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(60, 53);
            btn_aggiungi.TabIndex = 1;
            btn_aggiungi.Text = "+";
            btn_aggiungi.UseVisualStyleBackColor = true;
            // 
            // txt_golOspite
            // 
            txt_golOspite.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_golOspite.Location = new Point(536, 35);
            txt_golOspite.Name = "txt_golOspite";
            txt_golOspite.Size = new Size(155, 25);
            txt_golOspite.TabIndex = 7;
            // 
            // lbl_golOspite
            // 
            lbl_golOspite.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_golOspite.Location = new Point(536, 9);
            lbl_golOspite.Name = "lbl_golOspite";
            lbl_golOspite.Size = new Size(155, 23);
            lbl_golOspite.TabIndex = 6;
            lbl_golOspite.Text = "Goal Ospite";
            // 
            // txt_golCasa
            // 
            txt_golCasa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_golCasa.Location = new Point(361, 35);
            txt_golCasa.Name = "txt_golCasa";
            txt_golCasa.Size = new Size(155, 25);
            txt_golCasa.TabIndex = 5;
            // 
            // lbl_golCasa
            // 
            lbl_golCasa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_golCasa.Location = new Point(361, 9);
            lbl_golCasa.Name = "lbl_golCasa";
            lbl_golCasa.Size = new Size(155, 23);
            lbl_golCasa.TabIndex = 4;
            lbl_golCasa.Text = "Goal Casa";
            // 
            // txt_squadraOspite
            // 
            txt_squadraOspite.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_squadraOspite.Location = new Point(187, 35);
            txt_squadraOspite.Name = "txt_squadraOspite";
            txt_squadraOspite.Size = new Size(155, 25);
            txt_squadraOspite.TabIndex = 3;
            // 
            // lbl_squadraOspite
            // 
            lbl_squadraOspite.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_squadraOspite.Location = new Point(187, 9);
            lbl_squadraOspite.Name = "lbl_squadraOspite";
            lbl_squadraOspite.Size = new Size(155, 23);
            lbl_squadraOspite.TabIndex = 2;
            lbl_squadraOspite.Text = "Squadra Ospite";
            // 
            // txt_squadraCasa
            // 
            txt_squadraCasa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_squadraCasa.Location = new Point(12, 35);
            txt_squadraCasa.Name = "txt_squadraCasa";
            txt_squadraCasa.Size = new Size(155, 25);
            txt_squadraCasa.TabIndex = 1;
            // 
            // lbl_squadraCasa
            // 
            lbl_squadraCasa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_squadraCasa.Location = new Point(12, 9);
            lbl_squadraCasa.Name = "lbl_squadraCasa";
            lbl_squadraCasa.Size = new Size(155, 23);
            lbl_squadraCasa.TabIndex = 0;
            lbl_squadraCasa.Text = "Squadra Casa";
            // 
            // lst_elenco
            // 
            lst_elenco.FormattingEnabled = true;
            lst_elenco.ItemHeight = 15;
            lst_elenco.Location = new Point(6, 112);
            lst_elenco.Name = "lst_elenco";
            lst_elenco.Size = new Size(767, 274);
            lst_elenco.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_main);
            Name = "Form1";
            Text = "Form1";
            pnl_main.ResumeLayout(false);
            pnl_entries.ResumeLayout(false);
            pnl_entries.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_main;
        private Panel pnl_entries;
        private Label lbl_squadraCasa;
        private TextBox txt_squadraOspite;
        private Label lbl_squadraOspite;
        private TextBox txt_squadraCasa;
        private TextBox txt_golOspite;
        private Label lbl_golOspite;
        private TextBox txt_golCasa;
        private Label lbl_golCasa;
        private Button btn_aggiungi;
        private ListBox lst_elenco;
    }
}