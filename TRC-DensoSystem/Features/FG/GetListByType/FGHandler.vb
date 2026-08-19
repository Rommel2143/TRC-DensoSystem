Imports MySql.Data.MySqlClient

Public Class FGHandler

    Public Function GetByQRType(qrType As String) As List(Of FGDto)

        Dim result As New List(Of FGDto)

        Const sql As String =
            "SELECT id, partno, customerno, partname, model, color, " &
            "qrtype, qrlenght, qty " &
            "FROM denso_fg_masterlist " &
            "WHERE qrtype = @qrtype AND partno != '' GROUP BY partno " &
            "ORDER BY id"

        Using connection As MySqlConnection = Module1.connection()

            connection.Open()

            Using command As New MySqlCommand(sql, connection)

                command.Parameters.Add("@qrtype", MySqlDbType.VarChar).Value = qrType

                Using reader As MySqlDataReader = command.ExecuteReader()

                    While reader.Read()

                        Dim item As New FGDto()

                        item.Id = If(
                            reader.IsDBNull(reader.GetOrdinal("id")),
                            0,
                            Convert.ToInt32(reader("id"))
                        )

                        item.PartNo = If(
                            reader.IsDBNull(reader.GetOrdinal("partno")),
                            String.Empty,
                            Convert.ToString(reader("partno"))
                        )

                        item.CustomerNo = If(
                            reader.IsDBNull(reader.GetOrdinal("customerno")),
                            String.Empty,
                            Convert.ToString(reader("customerno"))
                        )

                        item.PartName = If(
                            reader.IsDBNull(reader.GetOrdinal("partname")),
                            String.Empty,
                            Convert.ToString(reader("partname"))
                        )

                        item.Model = If(
                            reader.IsDBNull(reader.GetOrdinal("model")),
                            String.Empty,
                            Convert.ToString(reader("model"))
                        )

                        item.Color = If(
                            reader.IsDBNull(reader.GetOrdinal("color")),
                            String.Empty,
                            Convert.ToString(reader("color"))
                        )

                        item.QRType = If(
                            reader.IsDBNull(reader.GetOrdinal("qrtype")),
                            String.Empty,
                            Convert.ToString(reader("qrtype"))
                        )

                        item.QRLenght = If(
                            reader.IsDBNull(reader.GetOrdinal("qrlenght")),
                            0,
                            Convert.ToInt32(reader("qrlenght"))
                        )

                        item.Qty = If(
                            reader.IsDBNull(reader.GetOrdinal("qty")),
                            0,
                            Convert.ToInt32(reader("qty"))
                        )

                        result.Add(item)

                    End While

                End Using

            End Using

        End Using

        Return result

    End Function

End Class