using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class AppModuleMetadataOperationLogClueProducer<T> : DynamicsClueProducer<T> where T : AppModuleMetadataOperationLog
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AppModuleMetadataOperationLogClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            this._factory = factory;

            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.AppModuleMetadataOperationLogId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=appmodulemetadataoperationlog&id={1}", _dynamics365CrawlJobData.Api, input.AppModuleMetadataOperationLogId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.AppModuleMetadataOperationLog.AppModuleMetadataOperationLogId] = input.AppModuleMetadataOperationLogId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModuleMetadataOperationLog.AppModuleId] = input.AppModuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModuleMetadataOperationLog.State] = input.State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModuleMetadataOperationLog.RetryCount] = input.RetryCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModuleMetadataOperationLog.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModuleMetadataOperationLog.StartedOn] = input.StartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModuleMetadataOperationLog.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}
