<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCapeFearSalons
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnManicure = New System.Windows.Forms.Button()
        Me.btnHaircut = New System.Windows.Forms.Button()
        Me.btnPedicure = New System.Windows.Forms.Button()
        Me.btnFacial = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblManicurePrice = New System.Windows.Forms.Label()
        Me.lblPedicurePrice = New System.Windows.Forms.Label()
        Me.lblHaircutPrice = New System.Windows.Forms.Label()
        Me.lblFacialPrice = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnMakeAppointment = New System.Windows.Forms.Button()
        Me.picFacial = New System.Windows.Forms.PictureBox()
        Me.picPedicure = New System.Windows.Forms.PictureBox()
        Me.picManicure = New System.Windows.Forms.PictureBox()
        Me.picHaircut = New System.Windows.Forms.PictureBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubtotalPrice = New System.Windows.Forms.Label()
        Me.lblTaxPrice = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        CType(Me.picFacial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPedicure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picManicure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHaircut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnManicure
        '
        Me.btnManicure.BackColor = System.Drawing.Color.Aqua
        Me.btnManicure.Location = New System.Drawing.Point(73, 169)
        Me.btnManicure.Name = "btnManicure"
        Me.btnManicure.Size = New System.Drawing.Size(75, 23)
        Me.btnManicure.TabIndex = 0
        Me.btnManicure.Text = "Manicure"
        Me.btnManicure.UseVisualStyleBackColor = False
        '
        'btnHaircut
        '
        Me.btnHaircut.BackColor = System.Drawing.Color.Aqua
        Me.btnHaircut.Location = New System.Drawing.Point(73, 295)
        Me.btnHaircut.Name = "btnHaircut"
        Me.btnHaircut.Size = New System.Drawing.Size(75, 23)
        Me.btnHaircut.TabIndex = 1
        Me.btnHaircut.Text = "Haircut"
        Me.btnHaircut.UseVisualStyleBackColor = False
        '
        'btnPedicure
        '
        Me.btnPedicure.BackColor = System.Drawing.Color.Aqua
        Me.btnPedicure.Location = New System.Drawing.Point(205, 169)
        Me.btnPedicure.Name = "btnPedicure"
        Me.btnPedicure.Size = New System.Drawing.Size(75, 23)
        Me.btnPedicure.TabIndex = 2
        Me.btnPedicure.Text = "Pedicure"
        Me.btnPedicure.UseVisualStyleBackColor = False
        '
        'btnFacial
        '
        Me.btnFacial.BackColor = System.Drawing.Color.Aqua
        Me.btnFacial.Location = New System.Drawing.Point(205, 295)
        Me.btnFacial.Name = "btnFacial"
        Me.btnFacial.Size = New System.Drawing.Size(75, 23)
        Me.btnFacial.TabIndex = 3
        Me.btnFacial.Text = "Facial"
        Me.btnFacial.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(41, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(291, 33)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Welcome to Cape Fear Salon"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.Location = New System.Drawing.Point(8, 42)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(357, 23)
        Me.lblSubtitle.TabIndex = 5
        Me.lblSubtitle.Text = "Please select the services you would like to purchase"
        '
        'lblManicurePrice
        '
        Me.lblManicurePrice.AutoSize = True
        Me.lblManicurePrice.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManicurePrice.Location = New System.Drawing.Point(83, 195)
        Me.lblManicurePrice.Name = "lblManicurePrice"
        Me.lblManicurePrice.Size = New System.Drawing.Size(50, 19)
        Me.lblManicurePrice.TabIndex = 6
        Me.lblManicurePrice.Text = "$10.00"
        '
        'lblPedicurePrice
        '
        Me.lblPedicurePrice.AutoSize = True
        Me.lblPedicurePrice.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedicurePrice.Location = New System.Drawing.Point(216, 195)
        Me.lblPedicurePrice.Name = "lblPedicurePrice"
        Me.lblPedicurePrice.Size = New System.Drawing.Size(50, 19)
        Me.lblPedicurePrice.TabIndex = 7
        Me.lblPedicurePrice.Text = "$15.00"
        '
        'lblHaircutPrice
        '
        Me.lblHaircutPrice.AutoSize = True
        Me.lblHaircutPrice.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaircutPrice.Location = New System.Drawing.Point(92, 321)
        Me.lblHaircutPrice.Name = "lblHaircutPrice"
        Me.lblHaircutPrice.Size = New System.Drawing.Size(42, 19)
        Me.lblHaircutPrice.TabIndex = 8
        Me.lblHaircutPrice.Text = "$5.00"
        '
        'lblFacialPrice
        '
        Me.lblFacialPrice.AutoSize = True
        Me.lblFacialPrice.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacialPrice.Location = New System.Drawing.Point(216, 321)
        Me.lblFacialPrice.Name = "lblFacialPrice"
        Me.lblFacialPrice.Size = New System.Drawing.Size(42, 19)
        Me.lblFacialPrice.TabIndex = 9
        Me.lblFacialPrice.Text = "$8.00"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Aqua
        Me.btnReset.Location = New System.Drawing.Point(47, 426)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnMakeAppointment
        '
        Me.btnMakeAppointment.BackColor = System.Drawing.Color.Aqua
        Me.btnMakeAppointment.Location = New System.Drawing.Point(188, 426)
        Me.btnMakeAppointment.Name = "btnMakeAppointment"
        Me.btnMakeAppointment.Size = New System.Drawing.Size(127, 23)
        Me.btnMakeAppointment.TabIndex = 11
        Me.btnMakeAppointment.Text = "Make Appointment"
        Me.btnMakeAppointment.UseVisualStyleBackColor = False
        '
        'picFacial
        '
        Me.picFacial.Image = Global.CapeFearSalons.My.Resources.Resources.Facial
        Me.picFacial.Location = New System.Drawing.Point(179, 211)
        Me.picFacial.Name = "picFacial"
        Me.picFacial.Size = New System.Drawing.Size(136, 78)
        Me.picFacial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFacial.TabIndex = 15
        Me.picFacial.TabStop = False
        '
        'picPedicure
        '
        Me.picPedicure.Image = Global.CapeFearSalons.My.Resources.Resources.Pedicure
        Me.picPedicure.Location = New System.Drawing.Point(179, 85)
        Me.picPedicure.Name = "picPedicure"
        Me.picPedicure.Size = New System.Drawing.Size(136, 78)
        Me.picPedicure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPedicure.TabIndex = 14
        Me.picPedicure.TabStop = False
        '
        'picManicure
        '
        Me.picManicure.Image = Global.CapeFearSalons.My.Resources.Resources.Manicure
        Me.picManicure.Location = New System.Drawing.Point(38, 85)
        Me.picManicure.Name = "picManicure"
        Me.picManicure.Size = New System.Drawing.Size(136, 78)
        Me.picManicure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picManicure.TabIndex = 13
        Me.picManicure.TabStop = False
        '
        'picHaircut
        '
        Me.picHaircut.Image = Global.CapeFearSalons.My.Resources.Resources.Haircut
        Me.picHaircut.Location = New System.Drawing.Point(38, 211)
        Me.picHaircut.Name = "picHaircut"
        Me.picHaircut.Size = New System.Drawing.Size(136, 78)
        Me.picHaircut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHaircut.TabIndex = 12
        Me.picHaircut.TabStop = False
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(108, 350)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(57, 19)
        Me.lblSubtotal.TabIndex = 16
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(108, 373)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(31, 19)
        Me.lblTax.TabIndex = 17
        Me.lblTax.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(108, 397)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 19)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total:"
        '
        'lblSubtotalPrice
        '
        Me.lblSubtotalPrice.AutoSize = True
        Me.lblSubtotalPrice.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalPrice.Location = New System.Drawing.Point(164, 350)
        Me.lblSubtotalPrice.Name = "lblSubtotalPrice"
        Me.lblSubtotalPrice.Size = New System.Drawing.Size(60, 19)
        Me.lblSubtotalPrice.TabIndex = 19
        Me.lblSubtotalPrice.Text = "888.888"
        '
        'lblTaxPrice
        '
        Me.lblTaxPrice.AutoSize = True
        Me.lblTaxPrice.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxPrice.Location = New System.Drawing.Point(164, 373)
        Me.lblTaxPrice.Name = "lblTaxPrice"
        Me.lblTaxPrice.Size = New System.Drawing.Size(60, 19)
        Me.lblTaxPrice.TabIndex = 20
        Me.lblTaxPrice.Text = "888.888"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(164, 397)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(60, 19)
        Me.lblTotalPrice.TabIndex = 21
        Me.lblTotalPrice.Text = "888.888"
        '
        'frmCapeFearSalons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(374, 461)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTaxPrice)
        Me.Controls.Add(Me.lblSubtotalPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.picFacial)
        Me.Controls.Add(Me.picPedicure)
        Me.Controls.Add(Me.picManicure)
        Me.Controls.Add(Me.picHaircut)
        Me.Controls.Add(Me.btnMakeAppointment)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblFacialPrice)
        Me.Controls.Add(Me.lblHaircutPrice)
        Me.Controls.Add(Me.lblPedicurePrice)
        Me.Controls.Add(Me.lblManicurePrice)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnFacial)
        Me.Controls.Add(Me.btnPedicure)
        Me.Controls.Add(Me.btnHaircut)
        Me.Controls.Add(Me.btnManicure)
        Me.Name = "frmCapeFearSalons"
        Me.Text = "Cape Fear Spa"
        CType(Me.picFacial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPedicure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picManicure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHaircut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManicure As Button
    Friend WithEvents btnHaircut As Button
    Friend WithEvents btnPedicure As Button
    Friend WithEvents btnFacial As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblManicurePrice As Label
    Friend WithEvents lblPedicurePrice As Label
    Friend WithEvents lblHaircutPrice As Label
    Friend WithEvents lblFacialPrice As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnMakeAppointment As Button
    Friend WithEvents picHaircut As PictureBox
    Friend WithEvents picManicure As PictureBox
    Friend WithEvents picPedicure As PictureBox
    Friend WithEvents picFacial As PictureBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSubtotalPrice As Label
    Friend WithEvents lblTaxPrice As Label
    Friend WithEvents lblTotalPrice As Label
End Class
