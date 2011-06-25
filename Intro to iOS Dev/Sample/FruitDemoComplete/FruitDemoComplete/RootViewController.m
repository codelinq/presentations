//
//  RootViewController.m
//  FruitDemoComplete
//
//  Created by Scott Beardsley on 6/24/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import "RootViewController.h"
#import "FruitModel.h"
#import "FruitDetailViewController.h"

@implementation RootViewController
@synthesize fruits;

- (void)viewDidLoad
{
    [super viewDidLoad];
    
    self.fruits = [[NSMutableArray alloc] initWithObjects:
                   [[FruitModel alloc] initWithName:@"watermelon" withImage:@"watermelon.jpg"],
                   [[FruitModel alloc] initWithName:@"apple" withImage:@"apple.jpg"],
                   [[FruitModel alloc] initWithName:@"kiwi" withImage:@"kiwi.jpg"],
                   [[FruitModel alloc] initWithName:@"orange" withImage:@"orange.jpg"],
                   [[FruitModel alloc] initWithName:@"banana" withImage:@"banana.jpg"],nil];
    self.navigationItem.title = @"Fruit List";
}

- (void)viewWillAppear:(BOOL)animated
{
    [super viewWillAppear:animated];
}

- (void)viewDidAppear:(BOOL)animated
{
    [super viewDidAppear:animated];
}

- (void)viewWillDisappear:(BOOL)animated
{
	[super viewWillDisappear:animated];
}

- (void)viewDidDisappear:(BOOL)animated
{
	[super viewDidDisappear:animated];
}

/*
 // Override to allow orientations other than the default portrait orientation.
- (BOOL)shouldAutorotateToInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation {
	// Return YES for supported orientations.
	return (interfaceOrientation == UIInterfaceOrientationPortrait);
}
 */

// Customize the number of sections in the table view.
- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
    return [self.fruits count];
}

// Customize the appearance of table view cells.
- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    static NSString *CellIdentifier = @"Cell";
    
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:CellIdentifier];
    if (cell == nil) {
        cell = [[[UITableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:CellIdentifier] autorelease];
    }
    
    FruitModel *model = [self.fruits objectAtIndex:indexPath.row];

    // Configure the cell.
    [[cell textLabel] setText:[model name]];
    [[cell imageView] setImage:[UIImage imageNamed:[model image]]];
    return cell;
}

/*
// Override to support conditional editing of the table view.
- (BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Return NO if you do not want the specified item to be editable.
    return YES;
}
*/

/*
// Override to support editing the table view.
- (void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath
{
    if (editingStyle == UITableViewCellEditingStyleDelete)
    {
        // Delete the row from the data source.
        [tableView deleteRowsAtIndexPaths:[NSArray arrayWithObject:indexPath] withRowAnimation:UITableViewRowAnimationFade];
    }
    else if (editingStyle == UITableViewCellEditingStyleInsert)
    {
        // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view.
    }   
}
*/

/*
// Override to support rearranging the table view.
- (void)tableView:(UITableView *)tableView moveRowAtIndexPath:(NSIndexPath *)fromIndexPath toIndexPath:(NSIndexPath *)toIndexPath
{
}
*/

/*
// Override to support conditional rearranging of the table view.
- (BOOL)tableView:(UITableView *)tableView canMoveRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Return NO if you do not want the item to be re-orderable.
    return YES;
}
*/

- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    
    FruitDetailViewController *detailViewController = [[FruitDetailViewController alloc] initWithNibName:@"FruitDetailViewController" bundle:nil];
    // ...
    // Pass the selected object to the new view controller.
    detailViewController.title = @"Fruit";
    [self.navigationController pushViewController:detailViewController animated:YES];

    FruitModel *model = [self.fruits objectAtIndex:indexPath.row];
    [detailViewController.name setText:model.name];
    [detailViewController.imageView setImage:[UIImage imageNamed:model.image]];
    
    [detailViewController release];
	
}

- (void)didReceiveMemoryWarning
{
    // Releases the view if it doesn't have a superview.
    [super didReceiveMemoryWarning];
    
    // Relinquish ownership any cached data, images, etc that aren't in use.
}

- (void)viewDidUnload
{
    [super viewDidUnload];

    // Relinquish ownership of anything that can be recreated in viewDidLoad or on demand.
    // For example: self.myOutlet = nil;
}

- (void)dealloc
{
    [self.fruits release];
    [super dealloc];
}

@end
