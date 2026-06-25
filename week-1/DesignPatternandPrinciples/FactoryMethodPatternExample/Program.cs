using System;

interface IDocument
{
    void Open();
}

class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}

class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF Document");
    }
}

class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Excel Document");
    }
}

abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("========== FACTORY METHOD PATTERN ==========\n");

        DocumentFactory wordFactory =
            new WordDocumentFactory();

        DocumentFactory pdfFactory =
            new PdfDocumentFactory();

        DocumentFactory excelFactory =
            new ExcelDocumentFactory();

        Console.WriteLine("Creating Documents...\n");

        wordFactory.CreateDocument().Open();
        pdfFactory.CreateDocument().Open();
        excelFactory.CreateDocument().Open();

        Console.WriteLine("\nAll documents created successfully.");

        Console.WriteLine("\n============================================");
    }
}