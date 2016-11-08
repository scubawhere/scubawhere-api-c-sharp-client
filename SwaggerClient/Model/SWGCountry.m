#import "SWGCountry.h"

@implementation SWGCountry

- (instancetype)init {
  self = [super init];
  if (self) {
    // initialize property's default value, if any
    
  }
  return self;
}


/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper {
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"id": @"_id", @"countinent_id": @"countinentId", @"currency_id": @"currencyId", @"abbreviation": @"abbreviation", @"name": @"name" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"_id", @"countinentId", @"currencyId", @"abbreviation", @"name"];
  return [optionalProperties containsObject:propertyName];
}

@end
