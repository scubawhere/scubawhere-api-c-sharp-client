#import <Foundation/Foundation.h>
#import "SWGErrorModel.h"
#import "SWGInlineResponse20046.h"
#import "SWGInlineResponse2003.h"
#import "SWGInlineResponse20047.h"
#import "SWGTrip.h"
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


@interface SWGTripApi: NSObject <SWGApi>

extern NSString* kSWGTripApiErrorDomain;
extern NSInteger kSWGTripApiMissingParamErrorCode;

+(instancetype) sharedAPI;

/// Create a new trip
/// 
///
/// @param name 
/// @param duration 
/// @param locations 
/// @param tags 
/// @param _description  (optional)
/// @param boatRequired  (optional)
/// 
///  code:200 message:"Success (Resource created)",
///  code:422 message:"Unprocessable Entity (One or more parameter was invalid)"
///
/// @return SWGInlineResponse20046*
-(NSNumber*) createTripWithName: (NSString*) name
    duration: (NSNumber*) duration
    locations: (NSArray<NSNumber*>*) locations
    tags: (NSArray<NSNumber*>*) tags
    _description: (NSString*) _description
    boatRequired: (NSNumber*) boatRequired
    completionHandler: (void (^)(SWGInlineResponse20046* output, NSError* error)) handler;


/// Delete a trip by ID
/// 
///
/// @param _id 
/// 
///  code:200 message:"Success (Resource was deleted)",
///  code:404 message:"Not found (No package exists with the ID provided)"
///
/// @return SWGInlineResponse2003*
-(NSNumber*) deleteTripWithId: (NSNumber*) _id
    completionHandler: (void (^)(SWGInlineResponse2003* output, NSError* error)) handler;


/// Update a trip by ID
/// 
///
/// @param _id 
/// @param name 
/// @param duration 
/// @param locations 
/// @param tags 
/// @param _description  (optional)
/// @param boatRequired  (optional)
/// 
///  code:200 message:"Success (Resource created)",
///  code:404 message:"Not found (No boatroom with the ID provided)",
///  code:422 message:"Unprocessable Entity (One or more parameter was invalid)"
///
/// @return SWGInlineResponse20047*
-(NSNumber*) editTripWithId: (NSNumber*) _id
    name: (NSString*) name
    duration: (NSNumber*) duration
    locations: (NSArray<NSNumber*>*) locations
    tags: (NSArray<NSNumber*>*) tags
    _description: (NSString*) _description
    boatRequired: (NSNumber*) boatRequired
    completionHandler: (void (^)(SWGInlineResponse20047* output, NSError* error)) handler;


/// Retrieve all trips including any deleted models
/// 
///
/// 
///  code:200 message:"Success"
///
/// @return NSArray<SWGTrip>*
-(NSNumber*) getAllTripsWithCompletionHandler: 
    (void (^)(NSArray<SWGTrip>* output, NSError* error)) handler;


/// Retrieve all trips including any deleted models
/// 
///
/// 
///  code:200 message:"Success"
///
/// @return NSArray<SWGTrip>*
-(NSNumber*) getAllWithTrashedTripsWithCompletionHandler: 
    (void (^)(NSArray<SWGTrip>* output, NSError* error)) handler;


/// Retrieve a trip by ID
/// 
///
/// @param _id 
/// 
///  code:200 message:"Success (Resource Found)",
///  code:404 message:"Not Found (No timetable with that ID exists)",
///  code:422 message:"Unprocessable Entity (One or more parameter was invalid)"
///
/// @return SWGTrip*
-(NSNumber*) tripGetWithId: (NSNumber*) _id
    completionHandler: (void (^)(SWGTrip* output, NSError* error)) handler;



@end
