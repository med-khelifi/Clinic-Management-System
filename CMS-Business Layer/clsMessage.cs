using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsMessage
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int MessageID { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? SentAt { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsDeletedBySender { get; set; }
        public bool? IsDeletedByReceiver { get; set; }

        public clsMessage()
        {
            Mode = enMode.AddNew;
            MessageID = -1;
            SenderID = null;
            ReceiverID = null;
            Subject = null;
            Body = null;
            SentAt = null;
            IsRead = null;
            IsDeletedBySender = null;
            IsDeletedByReceiver = null;
        }
        private clsMessage(int MessageID, int? SenderID, int? ReceiverID, string Subject, string Body, DateTime? SentAt, bool? IsRead, bool? IsDeletedBySender, bool? IsDeletedByReceiver)
        {
            this.MessageID = MessageID;
            this.SenderID = SenderID;
            this.ReceiverID = ReceiverID;
            this.Subject = Subject;
            this.Body = Body;
            this.SentAt = SentAt;
            this.IsRead = IsRead;
            this.IsDeletedBySender = IsDeletedBySender;
            this.IsDeletedByReceiver = IsDeletedByReceiver;
            Mode = enMode.Update;
        }
        public bool Save()
        {
            bool success = false;
            if (Mode == enMode.AddNew)
            {
                success = _addnew();
                if (success)
                {
                    Mode = enMode.Update;
                }
            }
            else if (Mode == enMode.Update)
            {
                success = _update();
            }
            return success;
        }
        private bool _addnew()
        {
            this.MessageID = clsMessageData.AddNew(this.SenderID, this.ReceiverID, this.Subject, this.Body, this.SentAt, this.IsRead, this.IsDeletedBySender, this.IsDeletedByReceiver);
             return this.MessageID != 0;
        }
        private bool _update()
        {
            return clsMessageData.Update(MessageID, SenderID, ReceiverID, Subject, Body, SentAt, IsRead, IsDeletedBySender, IsDeletedByReceiver);
        }
        public bool Delete()
        {
            return clsMessageData.Delete(this.MessageID);
        }
        public static DataTable GetAllMessagesTable()
        {
            return clsMessageData.GetAll();
        }
        public static clsMessage Find(int MessageID)
        {
            int? SenderID = null;
            int? ReceiverID = null;
            string Subject = null;
            string Body = null;
            DateTime? SentAt = null;
            bool? IsRead = null;
            bool? IsDeletedBySender = null;
            bool? IsDeletedByReceiver = null;
            if (clsMessageData.GetByID(MessageID, ref SenderID, ref ReceiverID, ref Subject, ref Body, ref SentAt, ref IsRead, ref IsDeletedBySender, ref IsDeletedByReceiver))
            {
                return new clsMessage(MessageID, SenderID, ReceiverID, Subject, Body, SentAt, IsRead, IsDeletedBySender, IsDeletedByReceiver);
            }
            return null;
        }
    }
}
