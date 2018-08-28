using Akka.Actor;
using Akka.Event;
using eshop.Hubs;
using eshop.Messages;
using eshop.Messages.Registration;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Actors
{
    public class BaseActor : ReceiveActor
    {
        public const string ME = "/user/base/";
        public const string I = "base";

        public IActorRef _securityActRef;
        public IActorRef _investerFactoryRef;
        public IActorRef _baseMailerActRef;

        private ILoggingAdapter _log;

        protected override void PreStart()
        {
            //_baseMailerActRef = Context.ActorOf(BaseMailerActor.Props(), BaseMailerActor.I);
            //_securityActRef = Context.ActorOf(SecurityActor.Props(), SecurityActor.I);
            //_investerFactoryRef = Context.ActorOf(InvesterFactory.Props(), InvesterFactory.I);
        }


        public BaseActor()
        {
            _log = Context.GetLogger();

            Receive<RegisterShop_>(RegisterShop);
            //Receive<RegistrationValidationResults_>(RegistrationValidationResults);
            //Receive<ScheduleActivation_>(ScheduleActivation);
            //Receive<ActivateInvester_>(ActivateInvester);
            //Receive<ActivationValidationResults_ > (ActivationValidationResults);
            //Receive<ActivationCompleted_>(ActivationCompleted);
            //Receive<SetSignupHub_>(SetSignupHub);
        }


        private bool RegisterShop(RegisterShop_ msg)
        {
            _log.Info($"BaseActor: SecurityActor => validate this msg to register a new shop");
            _securityActRef.Tell(msg);
            return true;
        }


        //private bool RegistrationValidationResults(RegistrationValidationResults_ msg)
        //{
        //    //if validation was fine we tell the factory to register the invester
        //    if (msg.IsValid)
        //    {
        //        _log.Info($"BaseActor: InvesterFactoryActor => register this invester");
        //        _investerFactoryRef.Tell(msg.RegisterInvesterMsg);
        //    }
        //    else
        //    {
        //        //nyd
        //        //send back a reply to the signup channel that things failed
        //        this._baseMailerActRef.Tell(new RegistrationValidationErrors_(msg.Errors,msg.RegisterInvesterMsg));
        //    }
        //    return true;
        //}

        //private bool ScheduleActivation(ScheduleActivation_ msg)
        //{
        //    _log.Info($"BaseActor: SecurityActor => schedule this investers activation");
        //    _securityActRef.Tell(msg);
        //    return true;
        //}


        //private bool ActivateInvester(ActivateInvester_ msg)
        //{
        //    _log.Info($"BaseActor: SecurityActor =>  validate this msg to activate an invester");
        //    _securityActRef.Tell(new ValidateActivationRequest_(msg));
        //    return true;
        //}

        //private bool ActivationValidationResults(ActivationValidationResults_ msg)
        //{
        //    //if validation was fine we tell the factory to activate the invester
        //    if (msg.IsValid)
        //    {
        //        _log.Info($"BaseActor: InvesterFactoryActor => activate this invester");
        //        _investerFactoryRef.Tell(new ActivateInvester_(
        //            msg.ActivateInvesterMsg.Code,
        //            msg.ActivateInvesterMsg.PhoneNumber,
        //            msg.InvestersName
        //        ));
        //    }
        //    else
        //    {
        //        //nyd
        //        //send back a reply to the activte channel that things failed

        //    }
        //    return true;
        //}

        //private bool ActivationCompleted(ActivationCompleted_ msg)
        //{
        //    _log.Info($"BaseActor: SecurityActor => activation complete");
        //    _securityActRef.Tell(msg);
        //    return true;
        //}

        //private bool SetSignupHub(SetSignupHub_ msg)
        //{
        //    //tell my children to set up this signup hub
        //    //these have children that will communicate to signup channels
        //    _baseMailerActRef.Tell(msg);
        //    _investerFactoryRef.Tell(msg);
        //    _securityActRef.Tell(msg);
        //    return true;
        //}



        public static Props Props()
        {
            return Akka.Actor.Props.Create(() => new BaseActor());
        }
    }
}

