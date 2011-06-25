//
//  RootViewController.h
//  FruitDemoComplete
//
//  Created by Scott Beardsley on 6/24/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface RootViewController : UITableViewController {
    NSMutableArray *fruits;
}

@property (nonatomic, retain) NSMutableArray *fruits;

@end
