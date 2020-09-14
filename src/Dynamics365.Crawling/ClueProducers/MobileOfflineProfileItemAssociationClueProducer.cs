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
    public abstract class MobileOfflineProfileItemAssociationClueProducer<T> : DynamicsClueProducer<T> where T : MobileOfflineProfileItemAssociation
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public MobileOfflineProfileItemAssociationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.MobileOfflineProfileItemAssociationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=mobileofflineprofileitemassociation&id={1}", _dynamics365CrawlJobData.Api, input.MobileOfflineProfileItemAssociationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.MobileOfflineProfileItemId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mobileofflineprofileitem, EntityEdgeType.Parent, input, input.MobileOfflineProfileItemId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.MobileOfflineProfileItemAssociationId] = input.MobileOfflineProfileItemAssociationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.SelectedRelationShipsSchema] = input.SelectedRelationShipsSchema.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.SelectedRelationShipsSchemaName] = input.SelectedRelationShipsSchemaName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.MobileOfflineProfileItemId] = input.MobileOfflineProfileItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.MobileOfflineProfileItemIdName] = input.MobileOfflineProfileItemIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.RelationshipId] = input.RelationshipId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.RelationshipDisplayName] = input.RelationshipDisplayName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.PublishedOn] = input.PublishedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.MobileOfflineProfileItemAssociationIdUnique] = input.MobileOfflineProfileItemAssociationIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.RelationshipData] = input.RelationshipData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.IsValidated] = input.IsValidated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.IsValidatedName] = input.IsValidatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.RelationshipName] = input.RelationshipName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItemAssociation.ProfileItemAssociationEntityFilter] = input.ProfileItemAssociationEntityFilter.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}
