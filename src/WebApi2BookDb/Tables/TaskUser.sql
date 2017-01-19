CREATE TABLE [dbo].[TaskUser](
	[TaskId] BIGINT NOT NULL,
	[UserId] BIGINT NOT NULL,
	[ts] rowversion not null,
	PRIMARY KEY (TaskId, UserId),
	FOREIGN KEY (UserId) REFERENCES dbo.[User](UserId),
	FOREIGN KEY (TaskId) REFERENCES dbo.[Task](TaskId)
);
go
	create index ix_TaskUser_UserId on TaskUser(UserId) 
go