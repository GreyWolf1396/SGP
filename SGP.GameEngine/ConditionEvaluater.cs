using SGP.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGP.GameEngine
{
    public class ConditionEvaluater
    {
        public async Task<bool> EvaluateConditions(Condition condition, GameSession session, string entityId, string )
        {

            switch (condition.Type)
            {
                case Domain.Enums.ConditionType.And:
                    return (await GetSubConditionsResults(condition.SubConditions)).All(item => true);
                case Domain.Enums.ConditionType.Or:
                    return (await GetSubConditionsResults(condition.SubConditions)).Any(item => true);
                case Domain.Enums.ConditionType.Not:
                    return (await GetSubConditionsResults(condition.SubConditions)).All(item => false);

                case Domain.Enums.ConditionType.Contains:
                    break;
                case Domain.Enums.ConditionType.Equal:
                    break;
                case Domain.Enums.ConditionType.Greater:
                    break;
                case Domain.Enums.ConditionType.Less:
                    break;
                case Domain.Enums.ConditionType.GreaterOrEqual:
                    break;
                case Domain.Enums.ConditionType.LessOrEqual:
                    break;

                default:
                    break;

            }

            return false;
        }

        private async Task<bool[]> GetSubConditionsResults(IEnumerable<Condition> conditions)
        {
            var tasks = conditions.Select(EvaluateConditions);
            return await Task.WhenAll(tasks);
        }
    }
}

