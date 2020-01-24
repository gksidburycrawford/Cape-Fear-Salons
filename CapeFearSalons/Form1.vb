'Name:     Cape Fear Salon
'Author:   Geterry Sidbury-Crawford
'Date:     10/15/2017
'Purpose:  This Windows application allows users To see the various services and
'          prices and once they have decided what they want, they can then submit an
'          appointment request.

Option Strict On

Public Class frmCapeFearSalons
    Const salesTax As Double = 0.07
    Dim dblManicurePrice As Double
    Dim dblPedicurePrice As Double
    Dim dblHaircutPrice As Double
    Dim dblFacialPrice As Double
    Dim dblSubTotalPrice As Double = salesTax * dblManicurePrice + dblPedicurePrice + dblHaircutPrice + dblFacialPrice
    Dim dblTaxPrice As Double = dblSubTotalPrice * 0.07
    Dim dblTotalPrice As Double = dblSubTotalPrice + dblTaxPrice

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picHaircut.Click

    End Sub

    Private Sub btnFacial_Click(sender As Object, e As EventArgs) Handles btnFacial.Click
        ' This event Handler adds $8.00 to the subtotal of the apointment,
        ' as well as disables the button.
        dblFacialPrice = 8.0

        lblSubtotalPrice.Text = dblSubTotalPrice.ToString("C")
        lblTaxPrice.Text = dblTaxPrice.ToString("C")
        lblTotalPrice.Text = dblTotalPrice.ToString("C")

        btnFacial.Enabled = False


    End Sub

    Private Sub btnHaircut_Click(sender As Object, e As EventArgs) Handles btnHaircut.Click
        dblHaircutPrice = 5.0

        lblSubtotalPrice.Text = dblSubTotalPrice.ToString("C")
        lblTaxPrice.Text = dblTaxPrice.ToString("C")
        lblTotalPrice.Text = dblTotalPrice.ToString("C")

        btnHaircut.Enabled = False
    End Sub

    Private Sub btnManicure_Click(sender As Object, e As EventArgs) Handles btnManicure.Click
        dblManicurePrice = 15.0

        lblSubtotalPrice.Text = dblSubTotalPrice.ToString("C")
        lblTaxPrice.Text = dblTaxPrice.ToString("C")
        lblTotalPrice.Text = dblTotalPrice.ToString("C")

        btnManicure.Enabled = False
    End Sub

    Private Sub btnPedicure_Click(sender As Object, e As EventArgs) Handles btnPedicure.Click
        dblPedicurePrice = 10.0

        lblSubtotalPrice.Text = dblSubTotalPrice.ToString("C")
        lblTaxPrice.Text = dblTaxPrice.ToString("C")
        lblTotalPrice.Text = dblTotalPrice.ToString("C")

        btnPedicure.Enabled = False

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lblSubtotalPrice.Text = " "
        lblTaxPrice.Text = " "
        lblTotalPrice.Text = " "

        dblPedicurePrice = 0
        dblManicurePrice = 0
        dblHaircutPrice = 0
        dblFacialPrice = 0

        btnFacial.Enabled = True
        btnHaircut.Enabled = True
        btnManicure.Enabled = True
        btnPedicure.Enabled = True

    End Sub

    Private Sub btnMakeAppointment_Click(sender As Object, e As EventArgs) Handles btnMakeAppointment.Click
        lblSubtotalPrice.Text = " "
        lblTaxPrice.Text = " "
        lblTotalPrice.Text = " "

        dblPedicurePrice = 0
        dblManicurePrice = 0
        dblHaircutPrice = 0
        dblFacialPrice = 0

        btnFacial.Enabled = True
        btnHaircut.Enabled = True
        btnManicure.Enabled = True
        btnPedicure.Enabled = True
    End Sub
End Class
