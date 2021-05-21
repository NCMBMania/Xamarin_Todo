using NCMBClient;

namespace Todo
{
    public class TodoItem
    {
        // [PrimaryKey, AutoIncrement]
        public string ObjectId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }

        public NCMBObject GetNCMBObject()
        {
            var obj = new NCMBObject("TodoItem");
            obj
               .Set("name", Name)
               .Set("notes", Notes)
               .Set("done", Done);
            if (!(ObjectId is null))
            {
                obj.Set("objectId", ObjectId);
            }
            return obj;
        }

        public void SetNCMBObject(NCMBObject obj)
        {
            ObjectId = obj.GetString("objectId");
            Name = obj.GetString("name");
            Notes = obj.GetString("notes");
            Done = obj.GetBoolean("done");
        }
    }
}
