class ExpertDocument : DocumentProgram
{
	public sealed override void EditDocument() => Console.WriteLine("Document Edited");
	public sealed override void SaveDocument() => Console.WriteLine("Document Saved in pdf format");
}
