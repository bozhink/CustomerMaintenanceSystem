ALTER TABLE [cms].[JobDetails]
    ADD CONSTRAINT [FK_Customer_JobDetails]
    FOREIGN KEY (CarNo)
    REFERENCES [cms].[Customer] (CarNo)
