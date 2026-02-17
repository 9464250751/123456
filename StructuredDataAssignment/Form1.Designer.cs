namespace StructuredDataAssignment;

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
        btnMakeVehicles = new Button();
        btnMakePeople = new Button();
        btnMakePets = new Button();
        btnMakeSmartPhones = new Button();
        SuspendLayout();
        // 
        // btnMakeVehicles
        // 
        btnMakeVehicles.Location = new Point(50, 50);
        btnMakeVehicles.Name = "btnMakeVehicles";
        btnMakeVehicles.Size = new Size(200, 50);
        btnMakeVehicles.TabIndex = 0;
        btnMakeVehicles.Text = "Make Vehicles";
        btnMakeVehicles.UseVisualStyleBackColor = true;
        btnMakeVehicles.Click += btnMakeVehicles_Click;
        // 
        // btnMakePeople
        // 
        btnMakePeople.Location = new Point(50, 120);
        btnMakePeople.Name = "btnMakePeople";
        btnMakePeople.Size = new Size(200, 50);
        btnMakePeople.TabIndex = 1;
        btnMakePeople.Text = "Make People";
        btnMakePeople.UseVisualStyleBackColor = true;
        btnMakePeople.Click += btnMakePeople_Click;
        // 
        // btnMakePets
        // 
        btnMakePets.Location = new Point(50, 190);
        btnMakePets.Name = "btnMakePets";
        btnMakePets.Size = new Size(200, 50);
        btnMakePets.TabIndex = 2;
        btnMakePets.Text = "Make Pets";
        btnMakePets.UseVisualStyleBackColor = true;
        btnMakePets.Click += btnMakePets_Click;
        // 
        // btnMakeSmartPhones
        // 
        btnMakeSmartPhones.Location = new Point(50, 260);
        btnMakeSmartPhones.Name = "btnMakeSmartPhones";
        btnMakeSmartPhones.Size = new Size(200, 50);
        btnMakeSmartPhones.TabIndex = 3;
        btnMakeSmartPhones.Text = "Make SmartPhones";
        btnMakeSmartPhones.UseVisualStyleBackColor = true;
        btnMakeSmartPhones.Click += btnMakeSmartPhones_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnMakeSmartPhones);
        Controls.Add(btnMakePets);
        Controls.Add(btnMakePeople);
        Controls.Add(btnMakeVehicles);
        Name = "Form1";
        Text = "Structured Data Assignment";
        ResumeLayout(false);
    }

    #endregion

    private Button btnMakeVehicles;
    private Button btnMakePeople;
    private Button btnMakePets;
    private Button btnMakeSmartPhones;
}
