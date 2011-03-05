//
//  ExScreenAppDelegate.h
//  ExScreen
//
//  Created by Scott Beardsley on 9/24/10.
//  Copyright 2010 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>

@class ExScreenViewController;

@interface ExScreenAppDelegate : NSObject <UIApplicationDelegate> {
    UIWindow *window;
    ExScreenViewController *viewController;
}

@property (nonatomic, retain) IBOutlet UIWindow *window;
@property (nonatomic, retain) IBOutlet ExScreenViewController *viewController;

@end

