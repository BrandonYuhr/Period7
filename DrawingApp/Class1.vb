Public Class Ngon
    Public Property Pen As Pen
    Public Property sides As Integer
    Public Property radius As Integer
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Dim points(sides - 1) As Point
        For index = 0 To sides - 1
            Dim x As Integer
            Dim y As Integer

            x = Math.Cos(index * 2 * Math.PI / sides) * radius
            y = Math.Sin(index * 2 * Math.PI / sides) * radius
            points(index) = New Point(m_a.X + x, m_a.Y + y)
        Next
        Using g As Graphics = Graphics.FromImage(m_image)
            '  g.DrawLine(Pen, m_a, m_b)
            'g.DrawArc(Pen, m_a.X, m_a.Y, 100, 100, 0, 90)
            '  g.DrawPie(Pen, m_a.X, m_a.Y, 100, 100, 0, 90)
            '  g.DrawRectangle(Pen, m_a.X, m_a.Y, 100, 100)
            g.DrawPolygon(Pen, points)
            'g.FillRectangle(New SolidBrush(Pen.Color), m_a.X, m_a.Y, 100, 100)
        End Using

    End Sub

End Class
