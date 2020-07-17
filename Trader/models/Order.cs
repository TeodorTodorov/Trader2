using System;

public class Order
{
    
    public DateTime TimeStamp { get; set; }
    public string ClOrdID { get; set; }
    public string Symbol { get; set; }
    public string Triggered { get; set; }
    public string StopPx { get; set; }
    public string OrdStatus { get; set; }
    public string OrdType { get; set; }
    public string OrderId { get; set; }
    public string Side { get; set; }
    public double? Price { get; set; }
    public int? OrderQty { get; set; }
    public int? DisplayQty { get; set; }
   
    public override string ToString()
    {
        return "ClordId: " + ClOrdID + " " + "Symbol: " + Symbol + " " + "tirggered: " + Triggered + " " + "stopPx: " + StopPx + " " + "OrdStatus: " + OrdStatus + " " + "Side: " + Side + " " + "Price: " + Price + " " + "OrderQty: " + OrderQty;
    }

}
