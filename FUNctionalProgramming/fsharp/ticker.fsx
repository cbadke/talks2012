open System
open System.Net

let getPrice ticker =
  let webClient = new WebClient()
  let data = webClient.DownloadString("http://ichart.finance.yahoo.com/table.csv?s=" + ticker)
  let secondLine = data.Split('\n').[1]
  let dataItems = secondLine.Split(',')
  Double.Parse(dataItems.[dataItems.Length - 1])

let tickers = ["AAPL"; "AMD"; "CSCO"; "GOOG"; "HPQ"; "INTC"; "MSFT"; "ORCL"; "QCOM"; "XRX"]

tickers
 |> List.map (fun t -> (t, (getPrice t)))
 |> List.filter (fun tp -> snd(tp) < 500.0)
 |> List.reduce (fun tp1 tp2 -> if snd(tp1) > snd(tp2) then tp1 else tp2)
 |> printfn "%O"

