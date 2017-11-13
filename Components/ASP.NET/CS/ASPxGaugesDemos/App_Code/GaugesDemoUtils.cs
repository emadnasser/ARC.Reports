using System.Collections.Generic;
using System.Text.RegularExpressions;
using DevExpress.Web;

public abstract class BasePropertyChangedHandler {
    public delegate void PropertyChangedAction(string propValue);
    Dictionary<string, PropertyChangedAction> actionsCore;
    //
    public BasePropertyChangedHandler() {
        actionsCore = new Dictionary<string, PropertyChangedAction>();
        CreateActions();
    }
    public void ProcessPropertyChanged(string propName, string propValue) {
        PropertyChangedAction action = null;
        if(actionsCore.TryGetValue(propName, out action)) action(propValue);
    }
    protected Dictionary<string, PropertyChangedAction> Actions {
        get { return actionsCore; }
    }
    protected abstract void CreateActions();

    protected int GetIntValue(string value, int defaultValue) {
        int result = defaultValue;
        int.TryParse(value, out result);
        return result;
    }
    protected float GetFloatValue(string value, float defaultValue) {
        float result = defaultValue;
        float.TryParse(value, out result);
        return result;
    }
}
public static class CallbackParameterParser {
    public static bool TryParse(CallbackEventArgsBase e, out string propName, out string propValue) {
        string pattern = "(?<propName>.*?)\\s*=\\s*(?<propValue>.*?)$";
        MatchCollection matches = Regex.Matches(e.Parameter, pattern);
        propName = propValue = null;
        if(matches.Count > 0) {
            propName = matches[0].Groups["propName"].Value;
            propValue = matches[0].Groups["propValue"].Value;
        }
        return propName != null;
    }
}
