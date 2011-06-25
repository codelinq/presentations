//
//  FruitModel.m
//  FruitDemoComplete
//
//  Created by Scott Beardsley on 6/24/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import "FruitModel.h"


@implementation FruitModel
@synthesize name, image;

- (id) initWithName:(NSString *) Name withImage: (NSString *) Image{

    self.name = Name;
    self.image = Image;
    return self;
}

-(void) dealloc{
    [self.name release];
    [self.image release];
    [super dealloc];
}
@end
