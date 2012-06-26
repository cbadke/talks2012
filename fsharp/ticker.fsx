open System
open System.Net

let getPrice ticker =
  let webClient = new WebClient()
  let data = webClient.DownloadString("http://ichart.finance.yahoo.com/table.csv?s=" + ticker)
  let secondLine = data.Split('\n').[1]
  let dataItems = secondLine.Split(',')
  Double.Parse(dataItems.[dataItems.Length - 1])

let tickers = ["AAPL"; "AMD"; "CSCO"; "GOOG"; "HPQ"; "INTC"; "MSFT"; "ORCL"; "QCOM"; "XRX"]
