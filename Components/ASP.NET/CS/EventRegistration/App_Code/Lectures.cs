using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SessionList : BindingList<Session> {
    public SessionList()
        : base() {
    }
    public SessionList(List<Session> sessions)
        : base() {
        this.AddRange(sessions);
    }
    public SessionList(SessionList sessions)
        : base() {
        this.AddRange(sessions);
    }
    public void AddRange(List<Session> sessions) {
        foreach(Session session in sessions)
            this.Add(session);
    }
    public void AddRange(SessionList sessions) {
        foreach(Session session in sessions)
            this.Add(session);
    }
    public Session GetById(string id) {
        foreach(Session session in Items)
            if(session.Id == id)
                return session;
        return null;
    }
    public SessionList GetFeaturedSessions() {
        return new SessionList(SelectMany(this, s => (s.Featured == true)));
    }
    static List<Session> SelectMany(SessionList source, Func<Session, bool> selector) {
        return (from session in source
                where selector(session)
                select session).ToList();
    }

    public SessionList CreateCopy() {
        SessionList result = new SessionList();
        foreach(Session session in this)
            result.Add(new Session(session));
        return result;
    }
}

public class SessionDataSource {
    SessionList sessions;

    public SessionDataSource(SessionList sessions) {
        if(sessions == null)
            DevExpress.XtraScheduler.Native.Exceptions.ThrowArgumentNullException("sessions");
        this.sessions = sessions;
    }
    public SessionDataSource()
        : this(new SessionList()) {
    }

    SessionList Sessions { get { return sessions; } }

    public void UpdateMethodHandler(Session session) {
        int eventIndex = session.Index;
        if(eventIndex >= 0) {
            Sessions.RemoveAt(eventIndex);
            Sessions.Insert(eventIndex, session);
        }
    }
    public IEnumerable SelectMethodHandler() {
        SessionList result = new SessionList();
        result.AddRange(Sessions);
        return result;
    }
}
