using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Foundation.SitecoreExtensions.Services
{
    public interface ITrackerService
    {
        bool IsActive { get; }
        void IdentifyContact(string source, string identifier);
        void TrackOutcome(Guid outcomeDefinitionId);
        void TrackPageEvent(Guid pageEventId, string text = null, string data = null, string dataKey = null, int? value = null);
        void TrackGoal(Guid goalId, string text = null, string data = null, string dataKey = null, int? value = null);
    }
}