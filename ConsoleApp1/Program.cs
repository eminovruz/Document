class Document
{
	public static DocumentProgram? CreateDocument(string data)
	{
		if (data == "Document Program") return new DocumentProgram();
		else if (data == "ProDocument Program") return new ProDocumentProgram();
		else if (data == "ExpertDocument") return new ExpertDocument();

		return null;
	}
}

class Program
{
	static void Main()
	{
		DocumentProgram d1 = new DocumentProgram();
		ProDocumentProgram p1 = new ProDocumentProgram();
		ExpertDocument e1 = new ExpertDocument();
		string? data;

		while (true)
		{
            Console.WriteLine("Document Program -- 1");
            Console.WriteLine("ProDocument Program -- 2");
            Console.WriteLine("ExpertDocument -- 3");
			data = Console.ReadLine();

			if(data == "1")
            {
				d1.OpenDocument();
				d1.EditDocument();
				d1.SaveDocument();

			}
			else if(data == "2")
            {
				p1.EditDocument();
				p1.SaveDocument();

            }
			else if(data == "3")
            {
				e1.EditDocument();
				e1.SaveDocument();
            }
			
		}
	}
}