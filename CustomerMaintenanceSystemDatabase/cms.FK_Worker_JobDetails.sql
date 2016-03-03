ALTER TABLE [cms].[JobDetails]
    ADD CONSTRAINT [FK_Worker_JobDetails]
    FOREIGN KEY (WorkerId)
    REFERENCES [cms].[Worker] (Id)
