//
//  FruitDetailViewController.h
//  FruitDemoComplete
//
//  Created by Scott Beardsley on 6/24/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "FruitModel.h"

@interface FruitDetailViewController : UIViewController {
    UILabel *name;
    UIImageView *imageView;
}
@property (nonatomic, retain) IBOutlet UILabel *name;
@property (nonatomic, retain) IBOutlet UIImageView *imageView;

@end
