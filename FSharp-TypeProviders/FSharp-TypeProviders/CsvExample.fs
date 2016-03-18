module CsvExample

open FSharp.Data

type csvProvider = CsvProvider<"MOCK_DATA.csv">

let DoCsv = 
    let csv = csvProvider.Load("MOCK_DATA.csv")

    for r in csv.Rows do
        printfn "CSV - %A, %s, %F %A" r.Id r.First_name r.Money r.Day_of_birth