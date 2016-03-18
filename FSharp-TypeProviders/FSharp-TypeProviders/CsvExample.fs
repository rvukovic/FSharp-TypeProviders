module CsvExample

open FSharp.Data

type csvProvider = CsvProvider<"MOCK_DATA.csv">

let DoCsv = 
    let csv = csvProvider.Load("MOCK_DATA.csv")

    for r in csv.Rows do
        printfn "%A, %s, %F" r.Id r.First_name r.Money 