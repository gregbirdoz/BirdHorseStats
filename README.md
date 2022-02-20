# BirdHorseStats
Horse Statistics and Machine Learning

Hosted on AWS at the following url:
http://birdhorsestats-dev.ap-southeast-2.elasticbeanstalk.com/

1st machine learning task (proposed):

Using Kaggle dataset - https://www.kaggle.com/yasserh/horse-survival-dataset - train application to identify mortality outcome for new user input test data.

Current Funtionality:
1. Takes horse health details in a form
2. Presents those details via the model (MVC)

TODO:
1. Train a machine learning model on the training dataset
2. Use the submitted health data to test the model 
3. Present the results of the test to the user

KNOWN ISSUES:
1. Problem with AWS root user preventing the use of SageMaker to train and test ML model. Alternative would be to use Sharpkit.learn .Net package - limited functionality.
2. Other issues in comments
