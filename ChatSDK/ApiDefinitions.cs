using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;
using UIKit;


namespace Binding
{

	// @protocol ZDKEngine
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface ZDKEngine
	{
	}

	// @protocol ZDKConfiguration <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface ZDKConfiguration
	{
	}

	// @interface ZDKChat : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChat
	{

		// +(void)initializeWithAccountKey:(NSString * _Nonnull)accountKey appId:(NSString * _Nullable)appId queue:(dispatch_queue_t _Nonnull)queue;
		[Static]
		[Export("initializeWithAccountKey:appId:queue:")]
		void InitializeWithAccountKey(string accountKey, [NullAllowed] string appId, DispatchQueue queue);
	}

	// @interface ZDKMessaging : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKMessaging
	{
		// @property (readonly, nonatomic, strong, class) ZDKMessaging * _Nonnull instance;
		[Static]
		[Export("instance", ArgumentSemantic.Strong)]
		ZDKMessaging Instance { get; }

		[Export("buildUIWithEngines:configs:error:")]
		[return: NullAllowed]
		UIViewController BuildUIWithEngines(ZDKEngine[] engines, ZDKConfiguration[] configs, [NullAllowed] out NSError error);

		// @property (readonly, nonatomic) BOOL isMessagingPresented;
		[Export("isMessagingPresented")]
		bool IsMessagingPresented { get; }

		// @property (nonatomic, weak) id<ZDKMessagingDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}


	

	// @interface ZDKConfigurations : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKConfigurations
	{
		// @property (readonly, copy, nonatomic) NSArray<id<ZDKConfiguration>> * _Nonnull configs;
		[Export("configs", ArgumentSemantic.Copy)]
		ZDKConfiguration[] Configs { get; }

		// -(instancetype _Nonnull)initWithConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs __attribute__((objc_designated_initializer));
		[Export("initWithConfigs:")]
		[DesignatedInitializer]
		IntPtr Constructor(ZDKConfiguration[] configs);
	}

	// @interface ZDKMessagingConfiguration : NSObject <ZDKConfiguration>
	[BaseType(typeof(ZDKConfiguration))]
	interface ZDKMessagingConfiguration : ZDKConfiguration
	{
		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) UIImage * _Nonnull botAvatar;
		[Export("botAvatar", ArgumentSemantic.Strong)]
		UIImage BotAvatar { get; set; }

		// @property (nonatomic) BOOL isMultilineResponseOptionsEnabled;
		[Export("isMultilineResponseOptionsEnabled")]
		bool IsMultilineResponseOptionsEnabled { get; set; }
	}

	// @interface ZDKChatEngine : NSObject
	[BaseType(typeof(ZDKEngine))]
	[DisableDefaultCtor]
	interface ZDKChatEngine: ZDKEngine
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }


		// +(ZDKChatEngine * _Nullable)engineAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Static]
		[Export("engineAndReturnError:")]
		[return: NullAllowed]
		ZDKChatEngine EngineAndReturnError([NullAllowed] out NSError error);
	}

	// @interface ZDKChatConfiguration : NSObject
	[BaseType(typeof(ZDKConfiguration))]
	interface ZDKChatConfiguration: ZDKConfiguration
	{

		// @property (nonatomic) BOOL isChatTranscriptPromptEnabled;
		[Export("isChatTranscriptPromptEnabled")]
		bool IsChatTranscriptPromptEnabled { get; set; }

		// @property (nonatomic) BOOL isPreChatFormEnabled;
		[Export("isPreChatFormEnabled")]
		bool IsPreChatFormEnabled { get; set; }

		// @property (nonatomic) BOOL isOfflineFormEnabled;
		[Export("isOfflineFormEnabled")]
		bool IsOfflineFormEnabled { get; set; }

		// @property (nonatomic) BOOL isAgentAvailabilityEnabled;
		[Export("isAgentAvailabilityEnabled")]
		bool IsAgentAvailabilityEnabled { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}


}