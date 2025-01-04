# InputsControls

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion de Compras
 Online que emplea muchos elementos aplicados en anteriores aplicaciones:
 casillas de verificacion, Listas, Combo Box, CheckBox, Radio Button
 Picture Box asi como el manejo de Cuadros de Mensajes para confirmar
 la salida de la aplicacion de compras.
 
 # Actualizacion: 03/01/2025
 # Hora: 21:52

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# InputsControls

# Description

This project consists of the development of an Online Shopping application
that uses many elements applied in previous applications:
checkboxes, Lists, Combo Box, CheckBox, Radio Button
Picture Box as well as the management of Message Boxes to confirm
the exit of the shopping application.

# Update: 01/03/2025
# Time: 21:52

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/d4695624-8d53-4a7a-9b1f-f13ffeb5e7a2)

Code of the Project:

Public Class frmOnlineShopper
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Estas declaraciones de programa se ejecutan cuando el formulario se carga

        'Agrega elementos a un cuadro de lista como estos:
        lbPeripherals.Items.Add("Disco duro adicional")
        lbPeripherals.Items.Add("impresora")
        lbPeripherals.Items.Add("Antena de Satelite")

        'Los cuadros combinados tambien se llenan con el metodo Add:
        cbPayMethod.Items.Add("Euros")
        cbPayMethod.Items.Add("Tarjeta")
        cbPayMethod.Items.Add("Libras esterlinas")

    End Sub

    Private Sub chMachine_CheckedChanged(sender As Object, e As EventArgs) Handles chMachine.CheckedChanged

        'Si la propiedad CheckState de una casilla de verificacion es 1, tiene una marca
        If chMachine.CheckState = 1 Then
            rbPC.Checked = False
            rbMacintosh.Checked = False
            rbLaptop.Checked = False
            pbPhone.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\phone.png")
            pbPhone.Visible = True
        Else
            'Si no tiene marca, oculta la imagen
            pbPhone.Visible = False
        End If
    End Sub

    Private Sub chCalculator_CheckedChanged(sender As Object, e As EventArgs) Handles chCalculator.CheckedChanged

        'Si la propiedad CheckState de una casilla de verificacion es 1, tiene una marca
        If chCalculator.CheckState = 1 Then
            pbCalculator.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\calculadora.png")
            pbCalculator.Visible = True
        Else
            'Si no tiene marca, oculta la imagen
            pbCalculator.Visible = False
        End If

    End Sub

    Private Sub chCopyMachine_CheckedChanged(sender As Object, e As EventArgs) Handles chCopyMachine.CheckedChanged
        'Si la propiedad CheckState de una casilla de verificacion es 1, tiene una marca
        If chCopyMachine.CheckState = 1 Then
            pbPeripherals.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\fotocopiadora.png")
            pbPeripherals.Visible = True
        Else
            'Si no tiene marca, oculta la imagen
            pbPeripherals.Visible = False
        End If
    End Sub

    Private Sub lbPeripherals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPeripherals.SelectedIndexChanged
        'El elemento que eligio (0-2) se encuentra dentro de la propiedad SelectedIndex
        Select Case lbPeripherals.SelectedIndex
            Case 0
                pbComputer.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\discoduro.png")
                pbComputer.Visible = True
            Case 1
                pbComputer.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\impresora.png")
                pbComputer.Visible = True
            Case 2
                pbTelecom.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\antena.png")
                pbTelecom.Visible = True
        End Select
    End Sub

    Private Sub rbPC_CheckedChanged(sender As Object, e As EventArgs) Handles rbPC.CheckedChanged

        'Si la propiedad Checked de una casilla de verificacion es 1, tiene una marca
        If rbPC.Checked Then
            pbPhone.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\pc.png")
            pbPhone.Visible = True
            rbLaptop.Checked = False
            rbMacintosh.Checked = False
        End If
    End Sub

    Private Sub rbMacintosh_CheckedChanged(sender As Object, e As EventArgs) Handles rbMacintosh.CheckedChanged

        'Si la propiedad Checked de una casilla de verificacion es 1, tiene una marca
        If rbMacintosh.Checked Then
            pbPhone.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\macintosh.png")
            pbPhone.Visible = True
            rbLaptop.Checked = False
            rbPC.Checked = False
        End If
    End Sub

    Private Sub rbLaptop_CheckedChanged(sender As Object, e As EventArgs) Handles rbLaptop.CheckedChanged
        'Si la propiedad Checked de una casilla de verificacion es 1, tiene una marca
        If rbLaptop.Checked Then
            pbPhone.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\laptop.png")
            pbPhone.Visible = True
            rbPC.Checked = False
            rbMacintosh.Checked = False
        End If
    End Sub

    Private Sub cbPayMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayMethod.SelectedIndexChanged

        'El elemento que eligio (0-2) se encuentra dentro de la propiedad SelectedIndex
        Select Case cbPayMethod.SelectedIndex
            Case 0
                PbMoney.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\euro.png")
                PbMoney.Visible = True
            Case 1
                PbMoney.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\tarjeta.png")
                PbMoney.Visible = True
            Case 2
                PbMoney.Image = System.Drawing.Image.FromFile("C:\Users\oswal\Desktop\Imagenes NET\libra.png")
                PbMoney.Visible = True
        End Select

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        'limpia la aplicacion de compras en todos sus elementos

        rbLaptop.Checked = False
        rbMacintosh.Checked = False
        rbPC.Checked = False
        chCalculator.Checked = False
        chCopyMachine.Checked = False
        chMachine.Checked = False

        PbMoney.Visible = False
        pbTelecom.Visible = False
        pbComputer.Visible = False

        cbPayMethod.Items.Clear()
        lbPeripherals.Items.Clear()
        cbPayMethod.Text = ""

    End Sub

    Private Sub FrmOnlineShopper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Mensaje de dialogo para confirmar que sale de la aplicacion
        If (MessageBox.Show("Desea salir de la Aplicacion de Compras?", "Online Shopper", MessageBoxButtons.OK, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub

End Class
