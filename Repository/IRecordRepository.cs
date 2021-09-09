using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
namespace CapstoneProject.Repository
{
    public interface IRecordRepository
    {
        RaceRecords GetRecord(int id);
        circuit Getcircuit(int id);
        RaceRequest GetRequest(int id);

        List<RaceRecords> GetRaceRecords();
        List<RaceRequest> GetRequestRecords();
        bool CreateRequest(RaceRequest record);
        bool RequestToRecordList(RaceRecords record);
        bool UpdateRecord(RaceRecords record);

        bool DeleteRecord(RaceRecords record);
        bool DeleteRequest(RaceRequest record);

        List<circuit> getCircuits();

        bool CreateCircuit(circuit circuit);
        bool deleteCircuit(circuit circuit);

        bool changeStatus(int id,RequestStatus requestStatus);

        bool addTime(int id, string timing);
    }
}
