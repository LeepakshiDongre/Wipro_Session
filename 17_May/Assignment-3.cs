using System;

abstract class Document
{
    public abstract void PrintContent();

    public void ShowDocumentType()
    {
        Console.WriteLine($"Document Type: {this.GetType().Name}");
    }

}
class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing word document");
       
    }
}
class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing pdf document");

    }
}
class Program
{
    static void Main()
    {
        Document word = new WordDocument();
        Document pdf = new PDFDocument();

        pdf.ShowDocumentType();
        pdf.PrintContent();

        word.ShowDocumentType();
        word.PrintContent();

    }
}