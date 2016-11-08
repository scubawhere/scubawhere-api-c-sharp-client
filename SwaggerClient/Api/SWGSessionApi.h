#import <Foundation/Foundation.h>
#import "SWGErrorModel.h"
#import "SWGInlineResponse20043.h"
#import "SWGInlineResponse2003.h"
#import "SWGInlineResponse20044.h"
#import "SWGInlineResponse20045.h"
#import "SWGSession.h"
#import "SWGApi.h"

/**
* Scubawhere API Documentation
* This is the documentation for scubawhere's RMS API. This API is only to be used by authorized parties with valid auth tokens.  [Learn about scubawhere](http://www.scubawhere.com) to become an authorized consumer of our API 
*
* OpenAPI spec version: 1.0.0
* Contact: bryan@scubawhere.com
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


@interface SWGSessionApi: NSObject <SWGApi>

extern NSString* kSWGSessionApiErrorDomain;
extern NSInteger kSWGSessionApiMissingParamErrorCode;

+(instancetype) sharedAPI;

/// Create a new session
/// 
///
/// @param start 
/// @param boatId  (optional)
/// @param tripId  (optional)
/// 
///  code:200 message:"Success (Resource created)",
///  code:422 message:"Unprocessable Entity (One or more parameter was invalid)"
///
/// @return SWGInlineResponse20043*
-(NSNumber*) createSessionWithStart: (NSDate*) start
    boatId: (NSNumber*) boatId
    tripId: (NSNumber*) tripId
    completionHandler: (void (^)(SWGInlineResponse20043* output, NSError* error)) handler;


/// Delete a session by ID
/// 
///
/// @param _id 
/// 
///  code:200 message:"Success (Resource was deleted)",
///  code:404 message:"Not found (No session exists with the ID provided)"
///
/// @return SWGInlineResponse2003*
-(NSNumber*) deleteSessionWithId: (NSNumber*) _id
    completionHandler: (void (^)(SWGInlineResponse2003* output, NSError* error)) handler;


/// Update a session by ID
/// 
///
/// @param _id 
/// @param start 
/// @param boatId  (optional)
/// 
///  code:200 message:"Success (Resource created)",
///  code:404 message:"Not found (No session with the ID provided)",
///  code:422 message:"Unprocessable Entity (One or more parameter was invalid)"
///
/// @return SWGInlineResponse20044*
-(NSNumber*) editSessionWithId: (NSNumber*) _id
    start: (NSDate*) start
    boatId: (NSNumber*) boatId
    completionHandler: (void (^)(SWGInlineResponse20044* output, NSError* error)) handler;


/// Retrieve all of tsessions that match a filter
/// 
///
/// @param after  (optional)
/// @param before  (optional)
/// @param tripId  (optional)
/// @param ticketId  (optional)
/// @param packageId  (optional)
/// @param courseId  (optional)
/// 
///  code:200 message:"Success"
///
/// @return SWGInlineResponse20045*
-(NSNumber*) filterSessionsWithAfter: (NSDate*) after
    before: (NSDate*) before
    tripId: (NSNumber*) tripId
    ticketId: (NSNumber*) ticketId
    packageId: (NSNumber*) packageId
    courseId: (NSNumber*) courseId
    completionHandler: (void (^)(SWGInlineResponse20045* output, NSError* error)) handler;


/// Retrieve all sessions including any deleted models
/// 
///
/// 
///  code:200 message:"Success"
///
/// @return NSArray<SWGSession>*
-(NSNumber*) getAllSessionsWithCompletionHandler: 
    (void (^)(NSArray<SWGSession>* output, NSError* error)) handler;


/// Retrieve all sessions including any deleted models
/// 
///
/// 
///  code:200 message:"Success"
///
/// @return NSArray<SWGSession>*
-(NSNumber*) getAllWithTrashedSessionsWithCompletionHandler: 
    (void (^)(NSArray<SWGSession>* output, NSError* error)) handler;


/// Retrieve the customer manifest for this session
/// 
///
/// @param _id 
/// 
///  code:200 message:"Success (Resource created)"
///
/// @return SWGInlineResponse20043*
-(NSNumber*) getManifestWithId: (NSNumber*) _id
    completionHandler: (void (^)(SWGInlineResponse20043* output, NSError* error)) handler;


/// Retrieve a session by ID
/// 
///
/// @param _id  (optional)
/// 
///  code:200 message:"Success (Resource was found)",
///  code:404 message:"Not found (No session exists with the ID provided)",
///  code:422 message:"Unproccessable Entity (One or more of the parameters was invalid)"
///
/// @return SWGInlineResponse20043*
-(NSNumber*) getSessionWithId: (NSNumber*) _id
    completionHandler: (void (^)(SWGInlineResponse20043* output, NSError* error)) handler;


/// Retrieve all of todays sessions
/// 
///
/// 
///  code:200 message:"Success"
///
/// @return SWGInlineResponse20045*
-(NSNumber*) getTodaySessionsWithCompletionHandler: 
    (void (^)(SWGInlineResponse20045* output, NSError* error)) handler;


/// Retrieve all of tommorows sessions
/// 
///
/// 
///  code:200 message:"Success"
///
/// @return SWGInlineResponse20045*
-(NSNumber*) getTommorowSessionsWithCompletionHandler: 
    (void (^)(SWGInlineResponse20045* output, NSError* error)) handler;



@end
