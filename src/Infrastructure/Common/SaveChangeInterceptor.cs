using Application.Commons.Interfaces;
using Domain.Commons;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.Common;

public class SaveChangeInterceptor : SaveChangesInterceptor
{
    private readonly IDateTime dateTime;

    public SaveChangeInterceptor(IDateTime dateTime)
    {
        this.dateTime = dateTime;
    }

    public override ValueTask<int> SavedChangesAsync(SaveChangesCompletedEventData eventData, int result, CancellationToken cancellationToken = default)
    {
        var entries = eventData.Context.ChangeTracker.Entries<BaseEntity<int>>();
        foreach (var entry in entries)
        {
            switch (entry.State)
            {
                case EntityState.Detached:
                    break;
                case EntityState.Unchanged:
                    break;
                case EntityState.Deleted:
                    break;
                case EntityState.Modified:
                    break;
                case EntityState.Added:
                    break;
                default:
                    break;
            }
        }
        return base.SavedChangesAsync(eventData, result, cancellationToken);
    }
}
