//using System;
//using System.Linq;

//using CluedIn.Core;
//using CluedIn.Core.Agent.Jobs;
//using CluedIn.Core.Crawling;
//using CluedIn.Core.Data;
//using CluedIn.Crawling.Dynamics365.Core;
//using CluedIn.Crawling.Dynamics365.Core.Models;
//using CluedIn.Crawling.Dynamics365.Vocabularies;
//using CluedIn.Crawling.Factories;
//using CluedIn.Crawling.Helpers;

//namespace CluedIn.Crawling.Dynamics365.ClueProducers
//{
//  public abstract class AttributeClueProducer<T> : DynamicsClueProducer<T> where T : Core.Models.Attribute
//    {
//    private readonly IClueFactory _factory;

//        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

//    public AttributeClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
//    {
//      if (factory == null)
//                throw new ArgumentNullException(nameof(factory));

//            this._factory = factory;

//            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
//    }

//    protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
//    {
//      if (input == null)
//      throw new ArgumentNullException(nameof(input));

//      var clue = this._factory.Create(EntityType.Unknown, input.AttributeId.ToString(), accountId);

//      var data = clue.Data.EntityData;

//       if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=attribute&id={1}", _dynamics365CrawlJobData.Api, input.AttributeId.ToString()), UriKind.Absolute, out Uri uri))
//                data.Uri = uri;

//      data.Name = input.Name;
///*

//*/
//data.Properties[Dynamics365Vocabulary.Attribute.AttributeId] = input.AttributeId.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.Attribute.Name] = input.Name.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.Attribute.ComponentState] = input.ComponentState.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.Attribute.SolutionId] = input.SolutionId.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.Attribute.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();

//      this.Customize(clue, input);

//      if (!data.OutgoingEdges.Any())
//          this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

//       return clue;
//    }
//  }
//}  

