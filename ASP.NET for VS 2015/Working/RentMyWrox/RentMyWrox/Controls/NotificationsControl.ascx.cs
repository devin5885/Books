using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RentMyWrox.Models;

namespace RentMyWrox.Controls
{
    public partial class NotificationsControl : System.Web.UI.UserControl
    {
        public enum DisplayType
        {
            AdminOnly,
            NonAdminOnly,
            Both
        }

        public DisplayType Display { get; set; }

        public DateTime? DateForDisplay { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!DateForDisplay.HasValue)
            {
                DateForDisplay = DateTime.Now;
            }

            using (RentMyWroxContext context = new RentMyWroxContext())
            {
                var notes = context.Notifications
                    .Where(x => x.DisplayStartDate <= DateForDisplay.Value
                                && x.DisplayEndDate >= DateForDisplay.Value);

                if (Display != null && Display != DisplayType.Both)
                {
                    notes = notes.Where(x => x.IsAdminOnly ==
                                             (Display == DisplayType.AdminOnly));
                }

                Notification note = notes.OrderByDescending(x => x.CreateDate)
                    .FirstOrDefault();

                if (note != null)
                {
                    NotificationTitle.Text = note.Title;
                    NotificationDetail.Text = note.Details;
                }
            }
        }
    }
}