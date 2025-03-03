namespace CarWorkshopApp.Services
{
    public static class InvoiceService
    {
        private static List<Invoice> invoices = new List<Invoice>();

        public static void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
        }
    }
}