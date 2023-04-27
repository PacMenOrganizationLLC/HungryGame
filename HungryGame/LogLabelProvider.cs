using Serilog.Sinks.Loki.Labels;
using Serilog.Sinks.Loki;

namespace HungryGame;

public class LogLabelProvider : ILogLabelProvider
{
    public IList<LokiLabel> GetLabels()
    {
        return new List<LokiLabel>
        {
            new LokiLabel("app", "hungrygame"),
        };
    }

    public IList<string> PropertiesAsLabels { get; set; } = new List<string>
    {
        "level", // Since 3.0.0, you need to explicitly add level if you want it!
        "app"
    };
    public IList<string> PropertiesToAppend { get; set; } = new List<string>
    {
        "app"
    };
    public LokiFormatterStrategy FormatterStrategy { get; set; } = LokiFormatterStrategy.SpecificPropertiesAsLabelsOrAppended;
}
