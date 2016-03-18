module JsonExample

open FSharp.Data

type jsonProvider1 = JsonProvider<"""
                                    { "name":"John", "age":94 }    
                                    """>

let DoJson1 =
    let json = jsonProvider1.Parse(""" { "name":"Tomas", "age":4 } """)
    
    printfn "%s %d" json.Name json.Age


//====================================================================
type jsonProvider2 = JsonProvider<"MOCK_DATA.json">

let DoJson2 = 
    let json = jsonProvider2.Load("MOCK_DATA.json")

    for j in json do
        printfn "JSON - %A %s %f %A" j.Id j.FirstName j.Money j.DayOfBirth 
        

