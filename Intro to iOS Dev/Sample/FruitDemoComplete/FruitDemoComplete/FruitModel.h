//
//  FruitModel.h
//  FruitDemoComplete
//
//  Created by Scott Beardsley on 6/24/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <Foundation/Foundation.h>


@interface FruitModel : NSObject {
    NSString *name;
    NSString *image;
}

@property (nonatomic, copy) NSString *name;
@property (nonatomic, retain) NSString *image;

- (id) initWithName:(NSString *) Name withImage: (NSString *) Image;

@end
